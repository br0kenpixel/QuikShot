namespace QuikShot
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            optionsGroup = new GroupBox();
            formatLabel = new Label();
            pathLabel = new Label();
            formatSelection = new ComboBox();
            selectBtn = new Button();
            pathInput = new TextBox();
            guideGroup = new GroupBox();
            guideText = new Label();
            actionsGroup = new GroupBox();
            exitBtn = new Button();
            startBtn = new Button();
            folderSelectorDialog = new FolderBrowserDialog();
            notifyHandle = new NotifyIcon(components);
            optionsGroup.SuspendLayout();
            guideGroup.SuspendLayout();
            actionsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // optionsGroup
            // 
            optionsGroup.Controls.Add(formatLabel);
            optionsGroup.Controls.Add(pathLabel);
            optionsGroup.Controls.Add(formatSelection);
            optionsGroup.Controls.Add(selectBtn);
            optionsGroup.Controls.Add(pathInput);
            optionsGroup.Location = new Point(12, 12);
            optionsGroup.Name = "optionsGroup";
            optionsGroup.Size = new Size(776, 93);
            optionsGroup.TabIndex = 0;
            optionsGroup.TabStop = false;
            optionsGroup.Text = "Options";
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Location = new Point(509, 20);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(73, 25);
            formatLabel.TabIndex = 4;
            formatLabel.Text = "Format:";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(6, 28);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(206, 25);
            pathLabel.TabIndex = 3;
            pathLabel.Text = "Save location (directory):";
            // 
            // formatSelection
            // 
            formatSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            formatSelection.FormattingEnabled = true;
            formatSelection.Items.AddRange(new object[] { "PNG", "JPEG", "WEBP" });
            formatSelection.Location = new Point(588, 17);
            formatSelection.Name = "formatSelection";
            formatSelection.Size = new Size(182, 33);
            formatSelection.TabIndex = 2;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(658, 53);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(112, 34);
            selectBtn.TabIndex = 1;
            selectBtn.Text = "Browse...";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += SelectBtn_Click;
            // 
            // pathInput
            // 
            pathInput.Location = new Point(6, 56);
            pathInput.Name = "pathInput";
            pathInput.ReadOnly = true;
            pathInput.Size = new Size(646, 31);
            pathInput.TabIndex = 0;
            // 
            // guideGroup
            // 
            guideGroup.Controls.Add(guideText);
            guideGroup.Location = new Point(12, 111);
            guideGroup.Name = "guideGroup";
            guideGroup.Size = new Size(776, 94);
            guideGroup.TabIndex = 1;
            guideGroup.TabStop = false;
            guideGroup.Text = "Guide";
            // 
            // guideText
            // 
            guideText.AutoSize = true;
            guideText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guideText.Location = new Point(6, 27);
            guideText.Name = "guideText";
            guideText.Size = new Size(437, 50);
            guideText.TabIndex = 0;
            guideText.Text = "Press [ALT+SHIFT+S] to display/hide this window.\r\nPress [ALT+SHIFT+T] to take a screenshot.";
            // 
            // actionsGroup
            // 
            actionsGroup.Controls.Add(exitBtn);
            actionsGroup.Controls.Add(startBtn);
            actionsGroup.Location = new Point(18, 211);
            actionsGroup.Name = "actionsGroup";
            actionsGroup.Size = new Size(764, 218);
            actionsGroup.TabIndex = 2;
            actionsGroup.TabStop = false;
            actionsGroup.Text = "Actions";
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(395, 149);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(363, 63);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += ExitBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(6, 149);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(383, 63);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start / Hide";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += StartBtn_Click;
            // 
            // notifyHandle
            // 
            notifyHandle.Text = "notification";
            notifyHandle.Visible = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actionsGroup);
            Controls.Add(guideGroup);
            Controls.Add(optionsGroup);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuikShot";
            Load += MainWindow_Load;
            optionsGroup.ResumeLayout(false);
            optionsGroup.PerformLayout();
            guideGroup.ResumeLayout(false);
            guideGroup.PerformLayout();
            actionsGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox optionsGroup;
        private Label formatLabel;
        private Label pathLabel;
        private ComboBox formatSelection;
        private Button selectBtn;
        private TextBox pathInput;
        private GroupBox guideGroup;
        private Label guideText;
        private GroupBox actionsGroup;
        private Button exitBtn;
        private Button startBtn;
        private FolderBrowserDialog folderSelectorDialog;
        private NotifyIcon notifyHandle;
    }
}
