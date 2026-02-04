namespace JapaneseLearningApp
{
    partial class TTSWarning
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
            label1 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            checkBoxDoNotShow = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 106);
            label1.TabIndex = 0;
            label1.Text = "The TTS will not pronounce text correctly unless the Japanese language pack is installed in Windows. Press okay to be taken to the settings page to install it.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(50, 118);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(167, 118);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // checkBoxDoNotShow
            // 
            checkBoxDoNotShow.AutoSize = true;
            checkBoxDoNotShow.Location = new Point(84, 147);
            checkBoxDoNotShow.Name = "checkBoxDoNotShow";
            checkBoxDoNotShow.Size = new Size(125, 19);
            checkBoxDoNotShow.TabIndex = 3;
            checkBoxDoNotShow.Text = "Do not show again";
            checkBoxDoNotShow.UseVisualStyleBackColor = true;
            // 
            // TTSWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 177);
            ControlBox = false;
            Controls.Add(checkBoxDoNotShow);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TTSWarning";
            Text = "WARNING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOK;
        private Button buttonCancel;
        private CheckBox checkBoxDoNotShow;
    }
}