namespace JapaneseLearningApp
{
    partial class MainApp
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
            buttonCorrect = new Button();
            buttonIncorrect = new Button();
            labelWord = new Label();
            buttonSettings = new Button();
            SuspendLayout();
            // 
            // buttonCorrect
            // 
            buttonCorrect.Location = new Point(230, 205);
            buttonCorrect.Name = "buttonCorrect";
            buttonCorrect.Size = new Size(94, 23);
            buttonCorrect.TabIndex = 0;
            buttonCorrect.Text = "Remembered";
            buttonCorrect.UseVisualStyleBackColor = true;
            buttonCorrect.Click += buttonCorrect_Click;
            // 
            // buttonIncorrect
            // 
            buttonIncorrect.Location = new Point(123, 205);
            buttonIncorrect.Name = "buttonIncorrect";
            buttonIncorrect.Size = new Size(75, 23);
            buttonIncorrect.TabIndex = 3;
            buttonIncorrect.Text = "Forgot";
            buttonIncorrect.UseVisualStyleBackColor = true;
            buttonIncorrect.Click += buttonIncorrect_Click;
            // 
            // labelWord
            // 
            labelWord.BorderStyle = BorderStyle.FixedSingle;
            labelWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(12, 9);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(438, 184);
            labelWord.TabIndex = 4;
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            labelWord.Click += labelWord_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(375, 205);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.Text = "Settings";
            buttonSettings.Click += buttonSettings_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 261);
            Controls.Add(buttonSettings);
            Controls.Add(labelWord);
            Controls.Add(buttonIncorrect);
            Controls.Add(buttonCorrect);
            Name = "MainApp";
            Text = "JLA";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCorrect;
        private Button buttonIncorrect;
        private Label labelWord;
        private Button buttonSettings;
    }
}