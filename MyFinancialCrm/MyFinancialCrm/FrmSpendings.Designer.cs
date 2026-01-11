namespace MyFinancialCrm
{
    partial class FrmSpendings
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
            this.btnBankProcessesForm = new System.Windows.Forms.Button();
            this.btnBillingsForm = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSpendingUpdate = new System.Windows.Forms.Button();
            this.btnSpendingDelete = new System.Windows.Forms.Button();
            this.btnSpendingAdd = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanks = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpendingDate = new System.Windows.Forms.DateTimePicker();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBankProcessesForm
            // 
            this.btnBankProcessesForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBankProcessesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessesForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBankProcessesForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBankProcessesForm.Location = new System.Drawing.Point(28, 255);
            this.btnBankProcessesForm.Name = "btnBankProcessesForm";
            this.btnBankProcessesForm.Size = new System.Drawing.Size(171, 49);
            this.btnBankProcessesForm.TabIndex = 2;
            this.btnBankProcessesForm.Text = "Banka Haraketleri";
            this.btnBankProcessesForm.UseVisualStyleBackColor = true;
            // 
            // btnBillingsForm
            // 
            this.btnBillingsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBillingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingsForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBillingsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillingsForm.Location = new System.Drawing.Point(28, 200);
            this.btnBillingsForm.Name = "btnBillingsForm";
            this.btnBillingsForm.Size = new System.Drawing.Size(171, 49);
            this.btnBillingsForm.TabIndex = 2;
            this.btnBillingsForm.Text = "Temel Giderlerim";
            this.btnBillingsForm.UseVisualStyleBackColor = true;
            this.btnBillingsForm.Click += new System.EventHandler(this.btnBillingsForm_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserId.Location = new System.Drawing.Point(196, 32);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(226, 27);
            this.txtUserId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "User Id :";
            // 
            // btnSpendingUpdate
            // 
            this.btnSpendingUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.btnSpendingUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpendingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingUpdate.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSpendingUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingUpdate.Location = new System.Drawing.Point(810, 176);
            this.btnSpendingUpdate.Name = "btnSpendingUpdate";
            this.btnSpendingUpdate.Size = new System.Drawing.Size(171, 49);
            this.btnSpendingUpdate.TabIndex = 11;
            this.btnSpendingUpdate.Text = "Harcama Güncelle";
            this.btnSpendingUpdate.UseVisualStyleBackColor = false;
            this.btnSpendingUpdate.Click += new System.EventHandler(this.btnSpendingUpdate_Click);
            // 
            // btnSpendingDelete
            // 
            this.btnSpendingDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.btnSpendingDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpendingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingDelete.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSpendingDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingDelete.Location = new System.Drawing.Point(810, 121);
            this.btnSpendingDelete.Name = "btnSpendingDelete";
            this.btnSpendingDelete.Size = new System.Drawing.Size(171, 49);
            this.btnSpendingDelete.TabIndex = 10;
            this.btnSpendingDelete.Text = "Harcama Sil";
            this.btnSpendingDelete.UseVisualStyleBackColor = false;
            this.btnSpendingDelete.Click += new System.EventHandler(this.btnSpendingDelete_Click);
            // 
            // btnSpendingAdd
            // 
            this.btnSpendingAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.btnSpendingAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpendingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingAdd.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSpendingAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingAdd.Location = new System.Drawing.Point(810, 66);
            this.btnSpendingAdd.Name = "btnSpendingAdd";
            this.btnSpendingAdd.Size = new System.Drawing.Size(171, 49);
            this.btnSpendingAdd.TabIndex = 9;
            this.btnSpendingAdd.Text = "Harcama Ekle";
            this.btnSpendingAdd.UseVisualStyleBackColor = false;
            this.btnSpendingAdd.Click += new System.EventHandler(this.btnSpendingAdd_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.btnSpendingList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSpendingList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendingList.Location = new System.Drawing.Point(810, 11);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(171, 49);
            this.btnSpendingList.TabIndex = 8;
            this.btnSpendingList.Text = "Harcama Listele";
            this.btnSpendingList.UseVisualStyleBackColor = false;
            this.btnSpendingList.Click += new System.EventHandler(this.btnSpendingList_Click);
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingTitle.Location = new System.Drawing.Point(196, 126);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(226, 27);
            this.txtSpendingTitle.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(47, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(118, 24);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Kullanıcı Adı.";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(28, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnSettingsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettingsForm.Location = new System.Drawing.Point(28, 365);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(171, 49);
            this.btnSettingsForm.TabIndex = 3;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = true;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnDashboardForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboardForm.Location = new System.Drawing.Point(28, 310);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(171, 49);
            this.btnDashboardForm.TabIndex = 2;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harcama Başlığı :";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(196, 87);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(226, 27);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama Id:";
            // 
            // btnBanks
            // 
            this.btnBanks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnBanks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBanks.Location = new System.Drawing.Point(28, 145);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(171, 49);
            this.btnBanks.TabIndex = 2;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(229, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 307);
            this.panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.SpendingDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnSpendingUpdate);
            this.panel2.Controls.Add(this.btnSpendingDelete);
            this.panel2.Controls.Add(this.btnSpendingAdd);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 244);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProcessesForm);
            this.panel1.Controls.Add(this.btnBillingsForm);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 549);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Harcama Tarihi :";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(196, 164);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(226, 27);
            this.txtSpendingAmount.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Harcama Miktarı :";
            // 
            // SpendingDate
            // 
            this.SpendingDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SpendingDate.Location = new System.Drawing.Point(196, 200);
            this.SpendingDate.Name = "SpendingDate";
            this.SpendingDate.Size = new System.Drawing.Size(226, 32);
            this.SpendingDate.TabIndex = 18;
            // 
            // btnCategories
            // 
            this.btnCategories.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategories.Location = new System.Drawing.Point(28, 87);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(171, 49);
            this.btnCategories.TabIndex = 15;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBankProcessesForm;
        private System.Windows.Forms.Button btnBillingsForm;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSpendingUpdate;
        private System.Windows.Forms.Button btnSpendingDelete;
        private System.Windows.Forms.Button btnSpendingAdd;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker SpendingDate;
        private System.Windows.Forms.Button btnCategories;
    }
}