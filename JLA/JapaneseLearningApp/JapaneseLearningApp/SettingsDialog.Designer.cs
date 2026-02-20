namespace JapaneseLearningApp
{
    partial class SettingsDialog
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
            checkBoxEnableTTS = new CheckBox();
            buttonDone = new Button();
            comboBoxVoiceGender = new ComboBox();
            trackBarVol = new TrackBar();
            label1 = new Label();
            labelVol = new Label();
            buttonTest = new Button();
            buttonCancel = new Button();
            checkBoxShowFuri = new CheckBox();
            checkBoxShowJap = new CheckBox();
            checkBoxShowRomaji = new CheckBox();
            comboBoxIntensity = new ComboBox();
            label2 = new Label();
            checkBoxEnableVRec = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBarVol).BeginInit();
            SuspendLayout();
            // 
            // checkBoxEnableTTS
            // 
            checkBoxEnableTTS.AutoSize = true;
            checkBoxEnableTTS.Location = new Point(12, 12);
            checkBoxEnableTTS.Name = "checkBoxEnableTTS";
            checkBoxEnableTTS.Size = new Size(82, 19);
            checkBoxEnableTTS.TabIndex = 0;
            checkBoxEnableTTS.Text = "Enable TTS";
            checkBoxEnableTTS.UseVisualStyleBackColor = true;
            checkBoxEnableTTS.Click += checkBoxEnableTTS_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(82, 202);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // comboBoxVoiceGender
            // 
            comboBoxVoiceGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoiceGender.FormattingEnabled = true;
            comboBoxVoiceGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxVoiceGender.Location = new Point(12, 37);
            comboBoxVoiceGender.Name = "comboBoxVoiceGender";
            comboBoxVoiceGender.Size = new Size(82, 23);
            comboBoxVoiceGender.TabIndex = 2;
            comboBoxVoiceGender.SelectedIndexChanged += comboBoxVoiceGender_SelectedIndexChanged_1;
            // 
            // trackBarVol
            // 
            trackBarVol.Location = new Point(100, 37);
            trackBarVol.Maximum = 100;
            trackBarVol.Minimum = 1;
            trackBarVol.Name = "trackBarVol";
            trackBarVol.Size = new Size(82, 45);
            trackBarVol.TabIndex = 3;
            trackBarVol.TickStyle = TickStyle.None;
            trackBarVol.Value = 100;
            trackBarVol.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Location = new Point(100, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Volume";
            // 
            // labelVol
            // 
            labelVol.AutoSize = true;
            labelVol.Location = new Point(188, 37);
            labelVol.Name = "labelVol";
            labelVol.Size = new Size(25, 15);
            labelVol.TabIndex = 5;
            labelVol.Text = "100";
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(239, 36);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 7;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(188, 202);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxShowFuri
            // 
            checkBoxShowFuri.AutoSize = true;
            checkBoxShowFuri.Location = new Point(12, 88);
            checkBoxShowFuri.Name = "checkBoxShowFuri";
            checkBoxShowFuri.Size = new Size(104, 19);
            checkBoxShowFuri.TabIndex = 9;
            checkBoxShowFuri.Text = "Show Furigana";
            checkBoxShowFuri.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowJap
            // 
            checkBoxShowJap.AutoSize = true;
            checkBoxShowJap.Location = new Point(12, 113);
            checkBoxShowJap.Name = "checkBoxShowJap";
            checkBoxShowJap.Size = new Size(137, 19);
            checkBoxShowJap.TabIndex = 10;
            checkBoxShowJap.Text = "Show Japanese Word";
            checkBoxShowJap.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowRomaji
            // 
            checkBoxShowRomaji.AutoSize = true;
            checkBoxShowRomaji.Location = new Point(12, 138);
            checkBoxShowRomaji.Name = "checkBoxShowRomaji";
            checkBoxShowRomaji.Size = new Size(95, 19);
            checkBoxShowRomaji.TabIndex = 11;
            checkBoxShowRomaji.Text = "Show Romaji";
            checkBoxShowRomaji.UseVisualStyleBackColor = true;
            // 
            // comboBoxIntensity
            // 
            comboBoxIntensity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIntensity.Items.AddRange(new object[] { "Light", "Standard", "Intensive" });
            comboBoxIntensity.Location = new Point(193, 109);
            comboBoxIntensity.Name = "comboBoxIntensity";
            comboBoxIntensity.Size = new Size(121, 23);
            comboBoxIntensity.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 13;
            label2.Text = "Study Intensity";
            // 
            // checkBoxEnableVRec
            // 
            checkBoxEnableVRec.AutoSize = true;
            checkBoxEnableVRec.Location = new Point(193, 152);
            checkBoxEnableVRec.Name = "checkBoxEnableVRec";
            checkBoxEnableVRec.Size = new Size(102, 19);
            checkBoxEnableVRec.TabIndex = 14;
            checkBoxEnableVRec.Text = "Enable Speech";
            checkBoxEnableVRec.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 237);
            ControlBox = false;
            Controls.Add(checkBoxEnableVRec);
            Controls.Add(label2);
            Controls.Add(comboBoxIntensity);
            Controls.Add(checkBoxShowRomaji);
            Controls.Add(checkBoxShowJap);
            Controls.Add(checkBoxShowFuri);
            Controls.Add(buttonCancel);
            Controls.Add(buttonTest);
            Controls.Add(labelVol);
            Controls.Add(label1);
            Controls.Add(trackBarVol);
            Controls.Add(comboBoxVoiceGender);
            Controls.Add(buttonDone);
            Controls.Add(checkBoxEnableTTS);
            Name = "SettingsDialog";
            Text = "SettingsDialog";
            ((System.ComponentModel.ISupportInitialize)trackBarVol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxEnableTTS;
        private Button buttonDone;
        private ComboBox comboBoxVoiceGender;
        private HScrollBar hScrollBar1;
        private TrackBar trackBarVol;
        private Label label1;
        private Label labelVol;
        private Button buttonTest;
        private Button buttonCancel;
        private CheckBox checkBoxShowFuri;
        private CheckBox checkBoxShowJap;
        private CheckBox checkBoxShowRomaji;
        private ComboBox comboBoxIntensity;
        private Label label2;
        private CheckBox checkBoxEnableVRec;
    }
}