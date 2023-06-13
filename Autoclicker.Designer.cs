namespace MelodyAutoclicker
{
    partial class Autoclicker
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
            btnStart = new Button();
            comboBoxSong = new ComboBox();
            labelSong = new Label();
            progressBarSong = new ProgressBar();
            timerTick = new System.Windows.Forms.Timer(components);
            timerSeconds = new System.Windows.Forms.Timer(components);
            labelTimeRemaining = new Label();
            labelX1 = new Label();
            labelY1 = new Label();
            labelX2 = new Label();
            labelY2 = new Label();
            labelXYCoords = new Label();
            timerMouse = new System.Windows.Forms.Timer(components);
            timerPrepare = new System.Windows.Forms.Timer(components);
            numericUpDownX1 = new NumericUpDown();
            numericUpDownX2 = new NumericUpDown();
            numericUpDownY1 = new NumericUpDown();
            numericUpDownY2 = new NumericUpDown();
            btnColorStart = new Button();
            timerColor = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(191, 27);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // comboBoxSong
            // 
            comboBoxSong.FormattingEnabled = true;
            comboBoxSong.Items.AddRange(new object[] { "Hymn to the Joy", "Frere Jacques", "Amazing Grace", "Brahms' Lullaby", "Happy Birthday to You", "Greensleeves", "Geothermy?", "Minuet", "Joy to the World", "Godly Imagination", "La Vie en Rose" });
            comboBoxSong.Location = new Point(12, 27);
            comboBoxSong.Name = "comboBoxSong";
            comboBoxSong.Size = new Size(156, 23);
            comboBoxSong.TabIndex = 1;
            // 
            // labelSong
            // 
            labelSong.AutoSize = true;
            labelSong.Location = new Point(12, 9);
            labelSong.Name = "labelSong";
            labelSong.Size = new Size(76, 15);
            labelSong.TabIndex = 2;
            labelSong.Text = "Select a song";
            // 
            // progressBarSong
            // 
            progressBarSong.Location = new Point(12, 192);
            progressBarSong.Name = "progressBarSong";
            progressBarSong.Size = new Size(254, 23);
            progressBarSong.TabIndex = 3;
            // 
            // timerTick
            // 
            timerTick.Interval = 675;
            timerTick.Tick += timerTick_Tick;
            // 
            // timerSeconds
            // 
            timerSeconds.Interval = 1000;
            timerSeconds.Tick += timerSeconds_Tick;
            // 
            // labelTimeRemaining
            // 
            labelTimeRemaining.AutoSize = true;
            labelTimeRemaining.Location = new Point(12, 174);
            labelTimeRemaining.Name = "labelTimeRemaining";
            labelTimeRemaining.Size = new Size(42, 15);
            labelTimeRemaining.TabIndex = 4;
            labelTimeRemaining.Text = "??s/??s";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Location = new Point(12, 65);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(56, 15);
            labelX1.TabIndex = 9;
            labelX1.Text = "Top left X";
            // 
            // labelY1
            // 
            labelY1.AutoSize = true;
            labelY1.Location = new Point(12, 118);
            labelY1.Name = "labelY1";
            labelY1.Size = new Size(56, 15);
            labelY1.TabIndex = 10;
            labelY1.Text = "Top left Y";
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Location = new Point(166, 65);
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(85, 15);
            labelX2.TabIndex = 11;
            labelX2.Text = "Bottom right X";
            // 
            // labelY2
            // 
            labelY2.AutoSize = true;
            labelY2.Location = new Point(166, 118);
            labelY2.Name = "labelY2";
            labelY2.Size = new Size(85, 15);
            labelY2.TabIndex = 12;
            labelY2.Text = "Bottom right Y";
            // 
            // labelXYCoords
            // 
            labelXYCoords.AutoSize = true;
            labelXYCoords.Location = new Point(12, 219);
            labelXYCoords.Name = "labelXYCoords";
            labelXYCoords.Size = new Size(51, 15);
            labelXYCoords.TabIndex = 13;
            labelXYCoords.Text = "X: 0, Y: 0";
            // 
            // timerMouse
            // 
            timerMouse.Enabled = true;
            timerMouse.Tick += timerMouse_Tick;
            // 
            // timerPrepare
            // 
            timerPrepare.Interval = 1000;
            timerPrepare.Tick += timerPrepare_Tick;
            // 
            // numericUpDownX1
            // 
            numericUpDownX1.Location = new Point(12, 83);
            numericUpDownX1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownX1.Name = "numericUpDownX1";
            numericUpDownX1.Size = new Size(100, 23);
            numericUpDownX1.TabIndex = 2;
            // 
            // numericUpDownX2
            // 
            numericUpDownX2.Location = new Point(166, 83);
            numericUpDownX2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownX2.Name = "numericUpDownX2";
            numericUpDownX2.Size = new Size(100, 23);
            numericUpDownX2.TabIndex = 4;
            // 
            // numericUpDownY1
            // 
            numericUpDownY1.Location = new Point(12, 136);
            numericUpDownY1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownY1.Name = "numericUpDownY1";
            numericUpDownY1.Size = new Size(100, 23);
            numericUpDownY1.TabIndex = 3;
            // 
            // numericUpDownY2
            // 
            numericUpDownY2.Location = new Point(166, 136);
            numericUpDownY2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownY2.Name = "numericUpDownY2";
            numericUpDownY2.Size = new Size(100, 23);
            numericUpDownY2.TabIndex = 5;
            // 
            // btnColorStart
            // 
            btnColorStart.Location = new Point(275, 26);
            btnColorStart.Name = "btnColorStart";
            btnColorStart.Size = new Size(75, 23);
            btnColorStart.TabIndex = 14;
            btnColorStart.Text = "ColorStart";
            btnColorStart.UseVisualStyleBackColor = true;
            btnColorStart.Click += btnColorStart_Click;
            // 
            // timerColor
            // 
            timerColor.Interval = 10;
            timerColor.Tick += timerColor_Tick;
            // 
            // Autoclicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 243);
            Controls.Add(btnColorStart);
            Controls.Add(numericUpDownY2);
            Controls.Add(numericUpDownY1);
            Controls.Add(numericUpDownX2);
            Controls.Add(numericUpDownX1);
            Controls.Add(labelXYCoords);
            Controls.Add(labelY2);
            Controls.Add(labelX2);
            Controls.Add(labelY1);
            Controls.Add(labelX1);
            Controls.Add(labelTimeRemaining);
            Controls.Add(progressBarSong);
            Controls.Add(labelSong);
            Controls.Add(comboBoxSong);
            Controls.Add(btnStart);
            MaximizeBox = false;
            Name = "Autoclicker";
            ShowIcon = false;
            Text = "Melody Autoclicker";
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private ComboBox comboBoxSong;
        private Label labelSong;
        private ProgressBar progressBarSong;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Timer timerSeconds;
        private Label labelTimeRemaining;
        private Label labelX1;
        private Label labelY1;
        private Label labelX2;
        private Label labelY2;
        private Label labelXYCoords;
        private System.Windows.Forms.Timer timerMouse;
        private System.Windows.Forms.Timer timerPrepare;
        private NumericUpDown numericUpDownX1;
        private NumericUpDown numericUpDownX2;
        private NumericUpDown numericUpDownY1;
        private NumericUpDown numericUpDownY2;
        private Button btnColorStart;
        private System.Windows.Forms.Timer timerColor;
    }
}