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
            buttonSettings = new Button();
            buttonIncorrect = new Button();
            buttonHesitant = new Button();
            labelWord = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelClick = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPerfect
            // 
            buttonPerfect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPerfect.Enabled = false;
            buttonPerfect.Location = new Point(299, 3);
            buttonPerfect.Name = "buttonPerfect";
            buttonPerfect.Size = new Size(144, 36);
            buttonPerfect.TabIndex = 0;
            buttonPerfect.TabStop = false;
            buttonPerfect.Tag = "Perfect";
            buttonPerfect.Text = "Remembered";
            buttonPerfect.UseVisualStyleBackColor = true;
            buttonPerfect.Click += buttonRating_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Bottom;
            buttonSettings.Location = new Point(197, 253);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.TabStop = false;
            buttonSettings.Text = "Settings";
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonIncorrect
            // 
            buttonIncorrect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonIncorrect.Enabled = false;
            buttonIncorrect.Location = new Point(3, 3);
            buttonIncorrect.Name = "buttonIncorrect";
            buttonIncorrect.Size = new Size(142, 36);
            buttonIncorrect.TabIndex = 5;
            buttonIncorrect.TabStop = false;
            buttonIncorrect.Tag = "Incorrect";
            buttonIncorrect.Text = "Forgot";
            buttonIncorrect.UseVisualStyleBackColor = true;
            buttonIncorrect.Click += buttonRating_Click;
            // 
            // buttonHesitant
            // 
            buttonHesitant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonHesitant.Enabled = false;
            buttonHesitant.Location = new Point(151, 3);
            buttonHesitant.Name = "buttonHesitant";
            buttonHesitant.Size = new Size(142, 36);
            buttonHesitant.TabIndex = 6;
            buttonHesitant.TabStop = false;
            buttonHesitant.Tag = "Hesitant";
            buttonHesitant.Text = "Hesitant";
            buttonHesitant.UseVisualStyleBackColor = true;
            buttonHesitant.Click += buttonRating_Click;
            // 
            // labelWord
            // 
            labelWord.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWord.BorderStyle = BorderStyle.FixedSingle;
            labelWord.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWord.Location = new Point(11, 9);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(446, 193);
            labelWord.TabIndex = 7;
            labelWord.TextAlign = ContentAlignment.MiddleCenter;
            labelWord.Click += labelWord_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonIncorrect, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonPerfect, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonHesitant, 1, 0);
            tableLayoutPanel1.Location = new Point(11, 205);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(446, 42);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // labelClick
            // 
            labelClick.Anchor = AnchorStyles.Bottom;
            labelClick.AutoSize = true;
            labelClick.Enabled = false;
            labelClick.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClick.Location = new Point(159, 134);
            labelClick.Name = "labelClick";
            labelClick.Size = new Size(151, 13);
            labelClick.TabIndex = 9;
            labelClick.Text = "CLICK TO REVEAL ANSWER";
            labelClick.Visible = false;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 281);
            Controls.Add(labelClick);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelWord);
            Controls.Add(buttonSettings);
            MinimumSize = new Size(482, 320);
            Name = "MainApp";
            Text = "JLA";
            FormClosing += MainApp_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPerfect;
        private Button buttonSettings;
        private Button buttonIncorrect;
        private Button buttonHesitant;
        private Label labelWord;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelClick;
    }
}