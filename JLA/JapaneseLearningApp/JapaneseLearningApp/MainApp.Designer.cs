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
            buttonPerfect = new Button();
            labelWord = new Label();
            buttonSettings = new Button();
            buttonIncorrect = new Button();
            buttonHesitant = new Button();
            SuspendLayout();
            // 
            // buttonPerfect
            // 
            buttonPerfect.Enabled = false;
            buttonPerfect.Location = new Point(260, 205);
            buttonPerfect.Name = "buttonPerfect";
            buttonPerfect.Size = new Size(94, 23);
            buttonPerfect.TabIndex = 0;
            buttonPerfect.Tag = "Perfect";
            buttonPerfect.Text = "Perfect";
            buttonPerfect.UseVisualStyleBackColor = true;
            buttonPerfect.Click += buttonRating_Click;
            // 
            // labelWord
            // 
            labelWord.BorderStyle = BorderStyle.FixedSingle;
            labelWord.Font = new Font("Meiryo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(16, 9);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(438, 184);
            labelWord.TabIndex = 4;
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            labelWord.Click += labelWord_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(383, 226);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.Text = "Settings";
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonIncorrect
            // 
            buttonIncorrect.Enabled = false;
            buttonIncorrect.Location = new Point(79, 205);
            buttonIncorrect.Name = "buttonIncorrect";
            buttonIncorrect.Size = new Size(75, 23);
            buttonIncorrect.TabIndex = 5;
            buttonIncorrect.Tag = "Incorrect";
            buttonIncorrect.Text = "Incorrect";
            buttonIncorrect.UseVisualStyleBackColor = true;
            buttonIncorrect.Click += buttonRating_Click;
            // 
            // buttonHesitant
            // 
            buttonHesitant.Enabled = false;
            buttonHesitant.Location = new Point(160, 205);
            buttonHesitant.Name = "buttonHesitant";
            buttonHesitant.Size = new Size(94, 23);
            buttonHesitant.TabIndex = 6;
            buttonHesitant.Tag = "Hesitant";
            buttonHesitant.Text = "Hesitant";
            buttonHesitant.UseVisualStyleBackColor = true;
            buttonHesitant.Click += buttonRating_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 259);
            Controls.Add(buttonHesitant);
            Controls.Add(buttonIncorrect);
            Controls.Add(buttonSettings);
            Controls.Add(labelWord);
            Controls.Add(buttonPerfect);
            Name = "MainApp";
            Text = "JLA";
            FormClosing += MainApp_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPerfect;
        private Label labelWord;
        private Button buttonSettings;
        private Button buttonIncorrect;
        private Button buttonHesitant;
    }
}