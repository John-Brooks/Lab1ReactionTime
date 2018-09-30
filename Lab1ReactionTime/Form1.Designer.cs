namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMaxError = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMinError = new System.Windows.Forms.Label();
            this.lblAverageError = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(205, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 34);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(9, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "|";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(9, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "|";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(9, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "|";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(9, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "|";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(9, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "|";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Stop Here!";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 125);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 34);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(175, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Maximum Error(+):";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxError
            // 
            this.lblMaxError.AutoSize = true;
            this.lblMaxError.Location = new System.Drawing.Point(272, 223);
            this.lblMaxError.Name = "lblMaxError";
            this.lblMaxError.Size = new System.Drawing.Size(29, 13);
            this.lblMaxError.TabIndex = 25;
            this.lblMaxError.Text = "0 ms";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(175, 246);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Maximum Error (-):";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(25, 12);
            this.numSeconds.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(48, 20);
            this.numSeconds.TabIndex = 31;
            this.numSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Fill rate in seconds to reach stop";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Avg. Absolute Error:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblMinError
            // 
            this.lblMinError.AutoSize = true;
            this.lblMinError.Location = new System.Drawing.Point(272, 246);
            this.lblMinError.Name = "lblMinError";
            this.lblMinError.Size = new System.Drawing.Size(29, 13);
            this.lblMinError.TabIndex = 34;
            this.lblMinError.Text = "0 ms";
            // 
            // lblAverageError
            // 
            this.lblAverageError.AutoSize = true;
            this.lblAverageError.Location = new System.Drawing.Point(272, 268);
            this.lblAverageError.Name = "lblAverageError";
            this.lblAverageError.Size = new System.Drawing.Size(29, 13);
            this.lblAverageError.TabIndex = 35;
            this.lblAverageError.Text = "0 ms";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(38, 191);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(120, 134);
            this.lbResults.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 175);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Trial Results";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(16, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 22);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "All values in ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lblAverageError);
            this.Controls.Add(this.lblMinError);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblMaxError);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Measurement Reaction Time ";
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblMaxError;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMinError;
        private System.Windows.Forms.Label lblAverageError;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

