namespace OnlineDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltemp_6 = new System.Windows.Forms.Label();
            this.lblWindS6 = new System.Windows.Forms.Label();
            this.lblDescription6 = new System.Windows.Forms.Label();
            this.lblCondition6 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbltemp_3 = new System.Windows.Forms.Label();
            this.lblWindS3 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblCondition3 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbltemp_5 = new System.Windows.Forms.Label();
            this.lblWindS5 = new System.Windows.Forms.Label();
            this.lblDescription5 = new System.Windows.Forms.Label();
            this.lblCondition5 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbltemp_4 = new System.Windows.Forms.Label();
            this.lblWindS4 = new System.Windows.Forms.Label();
            this.lblDescription4 = new System.Windows.Forms.Label();
            this.lblCondition4 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbltemp_2 = new System.Windows.Forms.Label();
            this.lblWindS2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblCondition2 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltemp1 = new System.Windows.Forms.Label();
            this.lblWindS1 = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblCondition1 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcityName = new System.Windows.Forms.Label();
            this.lblSouth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDifferece = new System.Windows.Forms.TextBox();
            this.lblDiff = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.lblGlobal = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTemp);
            this.groupBox2.Controls.Add(this.lbltemp_6);
            this.groupBox2.Controls.Add(this.lblWindS6);
            this.groupBox2.Controls.Add(this.lblDescription6);
            this.groupBox2.Controls.Add(this.lblCondition6);
            this.groupBox2.Controls.Add(this.lblDay6);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.lbltemp_3);
            this.groupBox2.Controls.Add(this.lblWindS3);
            this.groupBox2.Controls.Add(this.lblDescription3);
            this.groupBox2.Controls.Add(this.lblCondition3);
            this.groupBox2.Controls.Add(this.lblDay3);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.lbltemp_5);
            this.groupBox2.Controls.Add(this.lblWindS5);
            this.groupBox2.Controls.Add(this.lblDescription5);
            this.groupBox2.Controls.Add(this.lblCondition5);
            this.groupBox2.Controls.Add(this.lblDay5);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.lbltemp_4);
            this.groupBox2.Controls.Add(this.lblWindS4);
            this.groupBox2.Controls.Add(this.lblDescription4);
            this.groupBox2.Controls.Add(this.lblCondition4);
            this.groupBox2.Controls.Add(this.lblDay4);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.lbltemp_2);
            this.groupBox2.Controls.Add(this.lblWindS2);
            this.groupBox2.Controls.Add(this.lblDescription2);
            this.groupBox2.Controls.Add(this.lblCondition2);
            this.groupBox2.Controls.Add(this.lblDay2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbltemp1);
            this.groupBox2.Controls.Add(this.lblWindS1);
            this.groupBox2.Controls.Add(this.lblDescription1);
            this.groupBox2.Controls.Add(this.lblCondition1);
            this.groupBox2.Controls.Add(this.lblDay1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblnum);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblcityName);
            this.groupBox2.Controls.Add(this.lblSouth);
            this.groupBox2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(513, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 437);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weather Forcast:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbltemp_6
            // 
            this.lbltemp_6.AutoSize = true;
            this.lbltemp_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp_6.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp_6.Location = new System.Drawing.Point(546, 390);
            this.lbltemp_6.Name = "lbltemp_6";
            this.lbltemp_6.Size = new System.Drawing.Size(26, 18);
            this.lbltemp_6.TabIndex = 88;
            this.lbltemp_6.Text = "26";
            // 
            // lblWindS6
            // 
            this.lblWindS6.AutoSize = true;
            this.lblWindS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS6.Location = new System.Drawing.Point(546, 352);
            this.lblWindS6.Name = "lblWindS6";
            this.lblWindS6.Size = new System.Drawing.Size(63, 18);
            this.lblWindS6.TabIndex = 87;
            this.lblWindS6.Text = "12km/h";
            // 
            // lblDescription6
            // 
            this.lblDescription6.AutoSize = true;
            this.lblDescription6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription6.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription6.Location = new System.Drawing.Point(436, 390);
            this.lblDescription6.Name = "lblDescription6";
            this.lblDescription6.Size = new System.Drawing.Size(94, 18);
            this.lblDescription6.TabIndex = 86;
            this.lblDescription6.Text = "Description";
            // 
            // lblCondition6
            // 
            this.lblCondition6.AutoSize = true;
            this.lblCondition6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition6.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition6.Location = new System.Drawing.Point(436, 370);
            this.lblCondition6.Name = "lblCondition6";
            this.lblCondition6.Size = new System.Drawing.Size(89, 18);
            this.lblCondition6.TabIndex = 85;
            this.lblCondition6.Text = "Conditions";
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay6.Location = new System.Drawing.Point(436, 350);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(49, 20);
            this.lblDay6.TabIndex = 84;
            this.lblDay6.Text = "Days";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(329, 350);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(101, 62);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 83;
            this.pictureBox7.TabStop = false;
            // 
            // lbltemp_3
            // 
            this.lbltemp_3.AutoSize = true;
            this.lbltemp_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp_3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp_3.Location = new System.Drawing.Point(233, 390);
            this.lbltemp_3.Name = "lbltemp_3";
            this.lbltemp_3.Size = new System.Drawing.Size(26, 18);
            this.lbltemp_3.TabIndex = 82;
            this.lbltemp_3.Text = "26";
            // 
            // lblWindS3
            // 
            this.lblWindS3.AutoSize = true;
            this.lblWindS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS3.Location = new System.Drawing.Point(233, 352);
            this.lblWindS3.Name = "lblWindS3";
            this.lblWindS3.Size = new System.Drawing.Size(63, 18);
            this.lblWindS3.TabIndex = 81;
            this.lblWindS3.Text = "12km/h";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription3.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription3.Location = new System.Drawing.Point(123, 390);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(94, 18);
            this.lblDescription3.TabIndex = 80;
            this.lblDescription3.Text = "Description";
            // 
            // lblCondition3
            // 
            this.lblCondition3.AutoSize = true;
            this.lblCondition3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition3.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition3.Location = new System.Drawing.Point(123, 370);
            this.lblCondition3.Name = "lblCondition3";
            this.lblCondition3.Size = new System.Drawing.Size(89, 18);
            this.lblCondition3.TabIndex = 79;
            this.lblCondition3.Text = "Conditions";
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay3.Location = new System.Drawing.Point(123, 350);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(49, 20);
            this.lblDay3.TabIndex = 78;
            this.lblDay3.Text = "Days";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 77;
            this.pictureBox4.TabStop = false;
            // 
            // lbltemp_5
            // 
            this.lbltemp_5.AutoSize = true;
            this.lbltemp_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp_5.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp_5.Location = new System.Drawing.Point(546, 297);
            this.lbltemp_5.Name = "lbltemp_5";
            this.lbltemp_5.Size = new System.Drawing.Size(26, 18);
            this.lbltemp_5.TabIndex = 76;
            this.lbltemp_5.Text = "26";
            // 
            // lblWindS5
            // 
            this.lblWindS5.AutoSize = true;
            this.lblWindS5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS5.Location = new System.Drawing.Point(546, 259);
            this.lblWindS5.Name = "lblWindS5";
            this.lblWindS5.Size = new System.Drawing.Size(63, 18);
            this.lblWindS5.TabIndex = 75;
            this.lblWindS5.Text = "12km/h";
            // 
            // lblDescription5
            // 
            this.lblDescription5.AutoSize = true;
            this.lblDescription5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription5.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription5.Location = new System.Drawing.Point(436, 297);
            this.lblDescription5.Name = "lblDescription5";
            this.lblDescription5.Size = new System.Drawing.Size(94, 18);
            this.lblDescription5.TabIndex = 74;
            this.lblDescription5.Text = "Description";
            // 
            // lblCondition5
            // 
            this.lblCondition5.AutoSize = true;
            this.lblCondition5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition5.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition5.Location = new System.Drawing.Point(436, 277);
            this.lblCondition5.Name = "lblCondition5";
            this.lblCondition5.Size = new System.Drawing.Size(89, 18);
            this.lblCondition5.TabIndex = 73;
            this.lblCondition5.Text = "Conditions";
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay5.Location = new System.Drawing.Point(436, 257);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(49, 20);
            this.lblDay5.TabIndex = 72;
            this.lblDay5.Text = "Days";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(329, 257);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(101, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 71;
            this.pictureBox6.TabStop = false;
            // 
            // lbltemp_4
            // 
            this.lbltemp_4.AutoSize = true;
            this.lbltemp_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp_4.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp_4.Location = new System.Drawing.Point(546, 202);
            this.lbltemp_4.Name = "lbltemp_4";
            this.lbltemp_4.Size = new System.Drawing.Size(26, 18);
            this.lbltemp_4.TabIndex = 70;
            this.lbltemp_4.Text = "26";
            // 
            // lblWindS4
            // 
            this.lblWindS4.AutoSize = true;
            this.lblWindS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS4.Location = new System.Drawing.Point(546, 164);
            this.lblWindS4.Name = "lblWindS4";
            this.lblWindS4.Size = new System.Drawing.Size(63, 18);
            this.lblWindS4.TabIndex = 69;
            this.lblWindS4.Text = "12km/h";
            // 
            // lblDescription4
            // 
            this.lblDescription4.AutoSize = true;
            this.lblDescription4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription4.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription4.Location = new System.Drawing.Point(436, 202);
            this.lblDescription4.Name = "lblDescription4";
            this.lblDescription4.Size = new System.Drawing.Size(94, 18);
            this.lblDescription4.TabIndex = 68;
            this.lblDescription4.Text = "Description";
            // 
            // lblCondition4
            // 
            this.lblCondition4.AutoSize = true;
            this.lblCondition4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition4.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition4.Location = new System.Drawing.Point(436, 182);
            this.lblCondition4.Name = "lblCondition4";
            this.lblCondition4.Size = new System.Drawing.Size(89, 18);
            this.lblCondition4.TabIndex = 67;
            this.lblCondition4.Text = "Conditions";
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay4.Location = new System.Drawing.Point(436, 162);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(49, 20);
            this.lblDay4.TabIndex = 66;
            this.lblDay4.Text = "Days";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(329, 162);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // lbltemp_2
            // 
            this.lbltemp_2.AutoSize = true;
            this.lbltemp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp_2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp_2.Location = new System.Drawing.Point(228, 299);
            this.lbltemp_2.Name = "lbltemp_2";
            this.lbltemp_2.Size = new System.Drawing.Size(26, 18);
            this.lbltemp_2.TabIndex = 64;
            this.lbltemp_2.Text = "26";
            // 
            // lblWindS2
            // 
            this.lblWindS2.AutoSize = true;
            this.lblWindS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS2.Location = new System.Drawing.Point(228, 262);
            this.lblWindS2.Name = "lblWindS2";
            this.lblWindS2.Size = new System.Drawing.Size(63, 18);
            this.lblWindS2.TabIndex = 63;
            this.lblWindS2.Text = "12km/h";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription2.Location = new System.Drawing.Point(123, 301);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(94, 18);
            this.lblDescription2.TabIndex = 62;
            this.lblDescription2.Text = "Description";
            // 
            // lblCondition2
            // 
            this.lblCondition2.AutoSize = true;
            this.lblCondition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition2.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition2.Location = new System.Drawing.Point(123, 281);
            this.lblCondition2.Name = "lblCondition2";
            this.lblCondition2.Size = new System.Drawing.Size(89, 18);
            this.lblCondition2.TabIndex = 61;
            this.lblCondition2.Text = "Conditions";
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay2.Location = new System.Drawing.Point(123, 261);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(49, 20);
            this.lblDay2.TabIndex = 60;
            this.lblDay2.Text = "Days";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(22, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "Forcast";
            // 
            // lbltemp1
            // 
            this.lbltemp1.AutoSize = true;
            this.lbltemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltemp1.Location = new System.Drawing.Point(228, 208);
            this.lbltemp1.Name = "lbltemp1";
            this.lbltemp1.Size = new System.Drawing.Size(26, 18);
            this.lbltemp1.TabIndex = 57;
            this.lbltemp1.Text = "26";
            // 
            // lblWindS1
            // 
            this.lblWindS1.AutoSize = true;
            this.lblWindS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindS1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWindS1.Location = new System.Drawing.Point(228, 170);
            this.lblWindS1.Name = "lblWindS1";
            this.lblWindS1.Size = new System.Drawing.Size(63, 18);
            this.lblWindS1.TabIndex = 56;
            this.lblWindS1.Text = "12km/h";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDescription1.Location = new System.Drawing.Point(123, 210);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(94, 18);
            this.lblDescription1.TabIndex = 55;
            this.lblDescription1.Text = "Description";
            // 
            // lblCondition1
            // 
            this.lblCondition1.AutoSize = true;
            this.lblCondition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition1.ForeColor = System.Drawing.Color.Gold;
            this.lblCondition1.Location = new System.Drawing.Point(123, 190);
            this.lblCondition1.Name = "lblCondition1";
            this.lblCondition1.Size = new System.Drawing.Size(89, 18);
            this.lblCondition1.TabIndex = 54;
            this.lblCondition1.Text = "Conditions";
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDay1.Location = new System.Drawing.Point(123, 170);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(49, 20);
            this.lblDay1.TabIndex = 53;
            this.lblDay1.Text = "Days";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(355, 55);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 29);
            this.lblnum.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblcityName
            // 
            this.lblcityName.AutoSize = true;
            this.lblcityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcityName.ForeColor = System.Drawing.Color.Green;
            this.lblcityName.Location = new System.Drawing.Point(23, 27);
            this.lblcityName.Name = "lblcityName";
            this.lblcityName.Size = new System.Drawing.Size(122, 20);
            this.lblcityName.TabIndex = 48;
            this.lblcityName.Text = "Port Elizabeth";
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouth.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSouth.Location = new System.Drawing.Point(22, 59);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(153, 29);
            this.lblSouth.TabIndex = 47;
            this.lblSouth.Text = "South Africa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtLoc);
            this.groupBox1.Controls.Add(this.txtPC);
            this.groupBox1.Controls.Add(this.lblGlobal);
            this.groupBox1.Controls.Add(this.lblOnline);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblPC);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(3, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 335);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPercent);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.txtMail);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDifferece);
            this.groupBox3.Controls.Add(this.lblDiff);
            this.groupBox3.Controls.Add(this.Check);
            this.groupBox3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox3.Location = new System.Drawing.Point(24, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 205);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Checking Time Differences";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Location = new System.Drawing.Point(12, 174);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(35, 19);
            this.lblPercent.TabIndex = 13;
            this.lblPercent.Text = "%%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 174);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(105, 12);
            this.progressBar1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(237, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(218, 83);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(173, 26);
            this.txtMail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-Mail:";
            // 
            // txtDifferece
            // 
            this.txtDifferece.Location = new System.Drawing.Point(218, 33);
            this.txtDifferece.Name = "txtDifferece";
            this.txtDifferece.Size = new System.Drawing.Size(173, 26);
            this.txtDifferece.TabIndex = 7;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.ForeColor = System.Drawing.Color.Gold;
            this.lblDiff.Location = new System.Drawing.Point(15, 40);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(117, 19);
            this.lblDiff.TabIndex = 8;
            this.lblDiff.Text = "Difference:";
            // 
            // Check
            // 
            this.Check.ForeColor = System.Drawing.Color.Black;
            this.Check.Location = new System.Drawing.Point(53, 139);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(105, 29);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check Me";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // txtLoc
            // 
            this.txtLoc.Enabled = false;
            this.txtLoc.Location = new System.Drawing.Point(261, 64);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(196, 26);
            this.txtLoc.TabIndex = 15;
            // 
            // txtPC
            // 
            this.txtPC.Enabled = false;
            this.txtPC.Location = new System.Drawing.Point(261, 22);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(196, 26);
            this.txtPC.TabIndex = 14;
            // 
            // lblGlobal
            // 
            this.lblGlobal.AutoSize = true;
            this.lblGlobal.Location = new System.Drawing.Point(331, 103);
            this.lblGlobal.Name = "lblGlobal";
            this.lblGlobal.Size = new System.Drawing.Size(0, 19);
            this.lblGlobal.TabIndex = 13;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Gold;
            this.lblOnline.Location = new System.Drawing.Point(43, 67);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(124, 19);
            this.lblOnline.TabIndex = 12;
            this.lblOnline.Text = "Online Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(353, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 11;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.Color.Gold;
            this.lblPC.Location = new System.Drawing.Point(43, 25);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(83, 19);
            this.lblPC.TabIndex = 10;
            this.lblPC.Text = "PC Time:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.Gold;
            this.lblTemp.Location = new System.Drawing.Point(382, 59);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(29, 20);
            this.lblTemp.TabIndex = 91;
            this.lblTemp.Text = "26";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1143, 532);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Time Difference";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltemp_6;
        private System.Windows.Forms.Label lblWindS6;
        private System.Windows.Forms.Label lblDescription6;
        private System.Windows.Forms.Label lblCondition6;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbltemp_3;
        private System.Windows.Forms.Label lblWindS3;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.Label lblCondition3;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbltemp_5;
        private System.Windows.Forms.Label lblWindS5;
        private System.Windows.Forms.Label lblDescription5;
        private System.Windows.Forms.Label lblCondition5;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbltemp_4;
        private System.Windows.Forms.Label lblWindS4;
        private System.Windows.Forms.Label lblDescription4;
        private System.Windows.Forms.Label lblCondition4;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbltemp_2;
        private System.Windows.Forms.Label lblWindS2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblCondition2;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltemp1;
        private System.Windows.Forms.Label lblWindS1;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblCondition1;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcityName;
        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDifferece;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label lblGlobal;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblTemp;
    }
}

