using System.ComponentModel;
using System.Runtime.InteropServices;

namespace QuikShot
{
    public partial class MainWindow : Form
    {
        // Windows message code sent when a registered hotkey is pressed
        private const int WM_HOTKEY = 0x0312;

        // Modifier flags (can be combined with bitwise OR, e.g., Ctrl+F6)
        private const uint MOD_NONE = 0x0000;        // No modifier key required
        private const uint MOD_CONTROL = 0x0002;     // Ctrl key must be held
        private const uint MOD_SHIFT = 0x0004;       // Shift key must be held
        private const uint MOD_ALT = 0x0001;         // Alt key must be held

        private const int START_KEY_ID = 9000;
        private const int ACTION_KEY_ID = 9001;

        private const uint START_KEY_MODS = MOD_ALT | MOD_SHIFT;
        private const uint ACTION_KEY_MODS = MOD_ALT | MOD_SHIFT;

        private const Keys START_KEY = Keys.S;
        private const Keys ACTION_KEY = Keys.T;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            var regSuccess = RegisterKeyboardHooks();
            if (!regSuccess)
            {
                int error = Marshal.GetLastWin32Error();
                string message = new Win32Exception(error).Message;
                MessageBox.Show($"Failed to register global key hooks! ({message})", "QuikShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            UnregisterKeyboardHooks();
            base.OnHandleDestroyed(e);
        }

        // Intercepts all raw Windows messages sent to this form
        protected override void WndProc(ref Message m)
        {
            // Pass the message along to the base WndProc for normal processing
            base.WndProc(ref m);

            if (m.Msg != WM_HOTKEY)
            {
                return;
            }

            var hotkeyId = m.WParam.ToInt32();
            HandleBackgroundKeypress(hotkeyId);
        }

        private void HandleBackgroundKeypress(int hotkeyId)
        {
            switch (hotkeyId)
            {
                case START_KEY_ID:
                    ToggleHiddenMode();
                    break;
                case ACTION_KEY_ID:
                    TakeScreenshot();
                    break;
                default:
                    return;
            }
        }

        private bool RegisterKeyboardHooks()
        {
            return RegisterHotKey(Handle, START_KEY_ID, START_KEY_MODS, (uint)START_KEY) &&
                   RegisterHotKey(Handle, ACTION_KEY_ID, ACTION_KEY_MODS, (uint)ACTION_KEY);
        }

        private void UnregisterKeyboardHooks()
        {
            UnregisterHotKey(Handle, START_KEY_ID);
            UnregisterHotKey(Handle, ACTION_KEY_ID);
        }

        private void ShowToast(string title, string message)
        {
            notifyHandle.Icon = SystemIcons.Information;  // Needs an icon to show
            notifyHandle.Visible = true;
            notifyHandle.BalloonTipTitle = title;
            notifyHandle.BalloonTipText = message;
            notifyHandle.ShowBalloonTip(1000); // duration in ms (Windows may override this)
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            var result = folderSelectorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathInput.Text = folderSelectorDialog.SelectedPath;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartHiddenMode();
        }

        private void ToggleHiddenMode()
        {
            if (Visible)
            {
                StartHiddenMode();
            }
            else
            {
                ExitHiddenMode();
            }
        }

        private void StartHiddenMode()
        {
            if (pathInput.Text.Length == 0)
            {
                MessageBox.Show("Please select save location first!", "QuikShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            ShowToast("QuikShot", "Ready!");
        }

        private void ExitHiddenMode()
        {
            Show();
        }

        private void TakeScreenshot()
        {
            if (Visible) return;

            var bitmap = ScreenCapture.Capture();
            var captureWindow = new CaptureWindow(pathInput.Text, formatSelection.Text, bitmap);
            captureWindow.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            formatSelection.SelectedIndex = 0;
        }
    }
}
