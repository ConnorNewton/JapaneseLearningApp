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
            buttonEasy = new Button();
            buttonAgain = new Button();
            labelWord = new Label();
            buttonSettings = new Button();
            buttonHard = new Button();
            buttonGood = new Button();
            SuspendLayout();
            // 
            // buttonEasy
            // 
            buttonEasy.Location = new Point(275, 205);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(94, 23);
            buttonEasy.TabIndex = 0;
            buttonEasy.Text = "Easy";
            buttonEasy.UseVisualStyleBackColor = true;
            buttonEasy.Click += buttonRating_Click;
            // 
            // buttonAgain
            // 
            buttonAgain.Location = new Point(12, 205);
            buttonAgain.Name = "buttonAgain";
            buttonAgain.Size = new Size(75, 23);
            buttonAgain.TabIndex = 3;
            buttonAgain.Text = "Again";
            buttonAgain.UseVisualStyleBackColor = true;
            buttonAgain.Click += buttonRating_Click;
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
            buttonSettings.Location = new Point(379, 226);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.Text = "Settings";
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonHard
            // 
            buttonHard.Location = new Point(93, 205);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(75, 23);
            buttonHard.TabIndex = 5;
            buttonHard.Text = "Hard";
            buttonHard.UseVisualStyleBackColor = true;
            buttonHard.Click += buttonRating_Click;
            // 
            // buttonGood
            // 
            buttonGood.Location = new Point(174, 205);
            buttonGood.Name = "buttonGood";
            buttonGood.Size = new Size(94, 23);
            buttonGood.TabIndex = 6;
            buttonGood.Text = "Good";
            buttonGood.UseVisualStyleBackColor = true;
            buttonGood.Click += buttonRating_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 261);
            Controls.Add(buttonGood);
            Controls.Add(buttonHard);
            Controls.Add(buttonSettings);
            Controls.Add(labelWord);
            Controls.Add(buttonAgain);
            Controls.Add(buttonEasy);
            Name = "MainApp";
            Text = "JLA";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEasy;
        private Button buttonAgain;
        private Label labelWord;
        private Button buttonSettings;
        private Button buttonHard;
        private Button buttonGood;
    }
}