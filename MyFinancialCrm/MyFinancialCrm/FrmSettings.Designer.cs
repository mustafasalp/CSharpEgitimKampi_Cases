namespace MyFinancialCrm
{
    partial class FrmSettings
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
            this.txtSettingsPassword = new System.Windows.Forms.TextBox();
            this.txtSettingsUsername = new System.Windows.Forms.TextBox();
            this.linkGoToDashboard = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeInfos = new System.Windows.Forms.Button();
            this.txtSettingsConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSettingsPassword
            // 
            this.txtSettingsPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSettingsPassword.Location = new System.Drawing.Point(191, 160);
            this.txtSettingsPassword.Name = "txtSettingsPassword";
            this.txtSettingsPassword.Size = new System.Drawing.Size(185, 32);
            this.txtSettingsPassword.TabIndex = 24;
            // 
            // txtSettingsUsername
            // 
            this.txtSettingsUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSettingsUsername.Location = new System.Drawing.Point(191, 112);
            this.txtSettingsUsername.Name = "txtSettingsUsername";
            this.txtSettingsUsername.Size = new System.Drawing.Size(185, 32);
            this.txtSettingsUsername.TabIndex = 23;
            // 
            // linkGoToDashboard
            // 
            this.linkGoToDashboard.AutoSize = true;
            this.linkGoToDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkGoToDashboard.Location = new System.Drawing.Point(124, 402);
            this.linkGoToDashboard.Name = "linkGoToDashboard";
            this.linkGoToDashboard.Size = new System.Drawing.Size(167, 24);
            this.linkGoToDashboard.TabIndex = 21;
            this.linkGoToDashboard.TabStop = true;
            this.linkGoToDashboard.Text = "Back to Dashboard";
            this.linkGoToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoToDashboard_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username :";
            // 
            // btnChangeInfos
            // 
            this.btnChangeInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.btnChangeInfos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeInfos.Location = new System.Drawing.Point(115, 283);
            this.btnChangeInfos.Name = "btnChangeInfos";
            this.btnChangeInfos.Size = new System.Drawing.Size(189, 67);
            this.btnChangeInfos.TabIndex = 26;
            this.btnChangeInfos.Text = "Change Informations";
            this.btnChangeInfos.UseVisualStyleBackColor = false;
            this.btnChangeInfos.Click += new System.EventHandler(this.btnChangeInfos_Click);
            // 
            // txtSettingsConfirmPassword
            // 
            this.txtSettingsConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSettingsConfirmPassword.Location = new System.Drawing.Point(191, 204);
            this.txtSettingsConfirmPassword.Name = "txtSettingsConfirmPassword";
            this.txtSettingsConfirmPassword.Size = new System.Drawing.Size(185, 32);
            this.txtSettingsConfirmPassword.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password Confirm :";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(422, 492);
            this.Controls.Add(this.txtSettingsConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeInfos);
            this.Controls.Add(this.txtSettingsPassword);
            this.Controls.Add(this.txtSettingsUsername);
            this.Controls.Add(this.linkGoToDashboard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSettingsPassword;
        private System.Windows.Forms.TextBox txtSettingsUsername;
        private System.Windows.Forms.LinkLabel linkGoToDashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeInfos;
        private System.Windows.Forms.TextBox txtSettingsConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}