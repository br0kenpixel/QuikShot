namespace QuikShot
{
    partial class CaptureWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileName = new TextBox();
            fileNameLabel = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // fileName
            // 
            fileName.Location = new Point(12, 37);
            fileName.Name = "fileName";
            fileName.Size = new Size(354, 31);
            fileName.TabIndex = 0;
            fileName.Text = "image";
            fileName.TextAlign = HorizontalAlignment.Center;
            fileName.KeyDown += FileName_KeyDown;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(12, 9);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(236, 25);
            fileNameLabel.TabIndex = 1;
            fileNameLabel.Text = "File name without extension:";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(12, 98);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(203, 34);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "[Enter] Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += SaveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(221, 98);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(145, 34);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "[ESC] Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // CaptureWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 144);
            ControlBox = false;
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(fileNameLabel);
            Controls.Add(fileName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CaptureWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capture";
            TopMost = true;
            Load += CaptureWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fileName;
        private Label fileNameLabel;
        private Button saveBtn;
        private Button cancelBtn;
    }
}