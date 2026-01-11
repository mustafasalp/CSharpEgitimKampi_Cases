namespace MyFinancialCrm
{
    partial class FrmBanks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBankDashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBanksUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblZiraatBankBalance = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblVakifBankBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblisBankBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBankProcess1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBankProcess2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBankProcess3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBankProcess4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBankProcess5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblGarantiBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDenizBankBalance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblQNBbalance = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnSpendingsForm);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnBankDashboard);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 548);
            this.panel1.TabIndex = 0;
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSpendingsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingsForm.Location = new System.Drawing.Point(29, 103);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(171, 49);
            this.btnSpendingsForm.TabIndex = 4;
            this.btnSpendingsForm.Text = "Harcamalarım";
            this.btnSpendingsForm.UseVisualStyleBackColor = true;
            this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(29, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Location = new System.Drawing.Point(29, 323);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(171, 49);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnBankDashboard
            // 
            this.btnBankDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBankDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankDashboard.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBankDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBankDashboard.Location = new System.Drawing.Point(29, 268);
            this.btnBankDashboard.Name = "btnBankDashboard";
            this.btnBankDashboard.Size = new System.Drawing.Size(171, 49);
            this.btnBankDashboard.TabIndex = 2;
            this.btnBankDashboard.Text = "Dashboard";
            this.btnBankDashboard.UseVisualStyleBackColor = true;
            this.btnBankDashboard.Click += new System.EventHandler(this.btnBankDashboard_Click);
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 11F);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(29, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "Banka Haraketleri";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnBillForm
            // 
            this.btnBillForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBillForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillForm.Location = new System.Drawing.Point(29, 158);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(171, 49);
            this.btnBillForm.TabIndex = 2;
            this.btnBillForm.Text = "Temel Giderlerim";
            this.btnBillForm.UseVisualStyleBackColor = true;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBanks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBanks.Location = new System.Drawing.Point(29, 48);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(171, 49);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Kategoriler";
            this.btnBanks.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.lblBanksUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblBanksUserName
            // 
            this.lblBanksUserName.AutoSize = true;
            this.lblBanksUserName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBanksUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBanksUserName.Location = new System.Drawing.Point(1117, 10);
            this.lblBanksUserName.Name = "lblBanksUserName";
            this.lblBanksUserName.Size = new System.Drawing.Size(161, 35);
            this.lblBanksUserName.TabIndex = 3;
            this.lblBanksUserName.Text = "Kullanıcı İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ziraat Bankası";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lblZiraatBankBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(234, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 50);
            this.panel3.TabIndex = 6;
            // 
            // lblZiraatBankBalance
            // 
            this.lblZiraatBankBalance.AutoSize = true;
            this.lblZiraatBankBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraatBankBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblZiraatBankBalance.Location = new System.Drawing.Point(300, 1);
            this.lblZiraatBankBalance.Name = "lblZiraatBankBalance";
            this.lblZiraatBankBalance.Size = new System.Drawing.Size(113, 49);
            this.lblZiraatBankBalance.TabIndex = 7;
            this.lblZiraatBankBalance.Text = "0.00₺";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel4.Controls.Add(this.lblVakifBankBalance);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(234, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 53);
            this.panel4.TabIndex = 7;
            // 
            // lblVakifBankBalance
            // 
            this.lblVakifBankBalance.AutoSize = true;
            this.lblVakifBankBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblVakifBankBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVakifBankBalance.Location = new System.Drawing.Point(300, 0);
            this.lblVakifBankBalance.Name = "lblVakifBankBalance";
            this.lblVakifBankBalance.Size = new System.Drawing.Size(113, 49);
            this.lblVakifBankBalance.TabIndex = 7;
            this.lblVakifBankBalance.Text = "0.00₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vakıfbank";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.Controls.Add(this.lblisBankBalance);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(234, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 53);
            this.panel5.TabIndex = 8;
            // 
            // lblisBankBalance
            // 
            this.lblisBankBalance.AutoSize = true;
            this.lblisBankBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblisBankBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblisBankBalance.Location = new System.Drawing.Point(300, 0);
            this.lblisBankBalance.Name = "lblisBankBalance";
            this.lblisBankBalance.Size = new System.Drawing.Size(113, 49);
            this.lblisBankBalance.TabIndex = 7;
            this.lblisBankBalance.Text = "0.00₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "İş Bankası";
            // 
            // lblBankProcess1
            // 
            this.lblBankProcess1.AutoSize = true;
            this.lblBankProcess1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess1.Location = new System.Drawing.Point(6, 34);
            this.lblBankProcess1.Name = "lblBankProcess1";
            this.lblBankProcess1.Size = new System.Drawing.Size(69, 22);
            this.lblBankProcess1.TabIndex = 0;
            this.lblBankProcess1.Text = "Metin 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(922, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------";
            // 
            // lblBankProcess2
            // 
            this.lblBankProcess2.AutoSize = true;
            this.lblBankProcess2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess2.Location = new System.Drawing.Point(6, 83);
            this.lblBankProcess2.Name = "lblBankProcess2";
            this.lblBankProcess2.Size = new System.Drawing.Size(69, 22);
            this.lblBankProcess2.TabIndex = 5;
            this.lblBankProcess2.Text = "Metin 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(922, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------";
            // 
            // lblBankProcess3
            // 
            this.lblBankProcess3.AutoSize = true;
            this.lblBankProcess3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess3.Location = new System.Drawing.Point(6, 132);
            this.lblBankProcess3.Name = "lblBankProcess3";
            this.lblBankProcess3.Size = new System.Drawing.Size(69, 22);
            this.lblBankProcess3.TabIndex = 7;
            this.lblBankProcess3.Text = "Metin 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(922, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------";
            // 
            // lblBankProcess4
            // 
            this.lblBankProcess4.AutoSize = true;
            this.lblBankProcess4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess4.Location = new System.Drawing.Point(6, 181);
            this.lblBankProcess4.Name = "lblBankProcess4";
            this.lblBankProcess4.Size = new System.Drawing.Size(69, 22);
            this.lblBankProcess4.TabIndex = 9;
            this.lblBankProcess4.Text = "Metin 4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(922, 22);
            this.label14.TabIndex = 10;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------";
            // 
            // lblBankProcess5
            // 
            this.lblBankProcess5.AutoSize = true;
            this.lblBankProcess5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProcess5.Location = new System.Drawing.Point(6, 226);
            this.lblBankProcess5.Name = "lblBankProcess5";
            this.lblBankProcess5.Size = new System.Drawing.Size(69, 22);
            this.lblBankProcess5.TabIndex = 11;
            this.lblBankProcess5.Text = "Metin 5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(922, 22);
            this.label16.TabIndex = 12;
            this.label16.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblBankProcess5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblBankProcess4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblBankProcess3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblBankProcess2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBankProcess1);
            this.groupBox1.Location = new System.Drawing.Point(319, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 285);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son 5 Banka Haraketi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.panel6.Controls.Add(this.lblGarantiBalance);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(782, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(527, 53);
            this.panel6.TabIndex = 12;
            // 
            // lblGarantiBalance
            // 
            this.lblGarantiBalance.AutoSize = true;
            this.lblGarantiBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblGarantiBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGarantiBalance.Location = new System.Drawing.Point(300, 0);
            this.lblGarantiBalance.Name = "lblGarantiBalance";
            this.lblGarantiBalance.Size = new System.Drawing.Size(113, 49);
            this.lblGarantiBalance.TabIndex = 7;
            this.lblGarantiBalance.Text = "0.00₺";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Garanti BBVA";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(207)))), ((int)(((byte)(250)))));
            this.panel7.Controls.Add(this.lblDenizBankBalance);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(782, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(527, 53);
            this.panel7.TabIndex = 11;
            // 
            // lblDenizBankBalance
            // 
            this.lblDenizBankBalance.AutoSize = true;
            this.lblDenizBankBalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblDenizBankBalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDenizBankBalance.Location = new System.Drawing.Point(300, 0);
            this.lblDenizBankBalance.Name = "lblDenizBankBalance";
            this.lblDenizBankBalance.Size = new System.Drawing.Size(113, 49);
            this.lblDenizBankBalance.TabIndex = 7;
            this.lblDenizBankBalance.Text = "0.00₺";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(15, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "DenizBank";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.panel8.Controls.Add(this.lblQNBbalance);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(782, 212);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(527, 50);
            this.panel8.TabIndex = 10;
            // 
            // lblQNBbalance
            // 
            this.lblQNBbalance.AutoSize = true;
            this.lblQNBbalance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQNBbalance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQNBbalance.Location = new System.Drawing.Point(300, 1);
            this.lblQNBbalance.Name = "lblQNBbalance";
            this.lblQNBbalance.Size = new System.Drawing.Size(113, 49);
            this.lblQNBbalance.TabIndex = 7;
            this.lblQNBbalance.Text = "0.00₺";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(15, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 5;
            this.label18.Text = "QNB";
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1321, 602);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanks";
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBankDashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblZiraatBankBalance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblVakifBankBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblisBankBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBankProcess1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBankProcess2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBankProcess3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBankProcess4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBankProcess5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblGarantiBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblDenizBankBalance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblQNBbalance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblBanksUserName;
        private System.Windows.Forms.Button btnSpendingsForm;
    }
}