using System.Drawing.Imaging;

namespace QuikShot
{
    public partial class CaptureWindow : Form
    {
        private readonly string BasePath;
        private readonly string Format;
        private new readonly Bitmap Capture;

        public CaptureWindow(string basePath, string format, Bitmap capture)
        {
            InitializeComponent();
            BasePath = basePath;
            Format = format;
            Capture = capture;
        }

        private void CaptureWindow_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveCapture();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveCapture();
            }
        }

        private void SaveCapture()
        {
            var targetName = fileName.Text;

            if (string.IsNullOrEmpty(targetName) || string.IsNullOrWhiteSpace(targetName))
            {
                MessageBox.Show("Name must not be empty or whitespace!", "QuikShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fullPath = Path.Join(BasePath, targetName);
            fullPath = Path.ChangeExtension(fullPath, Format);

            var fmt = Format switch
            {
                "PNG" => ImageFormat.Png,
                "JPEG" => ImageFormat.Jpeg,
                "JPG" => ImageFormat.Jpeg,
                "WEBP" => ImageFormat.Webp,
                _ => throw new NotImplementedException()
            };

            if (Path.Exists(fullPath))
            {
                MessageBox.Show("File already exists!", "QuikShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Capture.Save(fullPath, fmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save file: {ex.Message}", "QuikShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Capture.Dispose();
            Close();
        }
    }
}
