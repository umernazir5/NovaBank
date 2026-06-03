namespace BankUI
{
    partial class CustomerApplyDebitCardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerApplyDebitCardForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBoxSidebarLogo = new System.Windows.Forms.PictureBox();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavTransfer = new System.Windows.Forms.Button();
            this.btnNavDebitCard = new System.Windows.Forms.Button();
            this.btnNavLoan = new System.Windows.Forms.Button();
            this.btnNavAdminReq = new System.Windows.Forms.Button();
            this.btnNavBalance = new System.Windows.Forms.Button();
            this.btnNavBankStmt = new System.Windows.Forms.Button();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelCardDetails = new System.Windows.Forms.Panel();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.lblCardExpiry = new System.Windows.Forms.Label();
            this.pictureBoxCardLogo = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSidebarLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelCardDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panelSidebar.Controls.Add(this.pictureBoxSidebarLogo);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.btnNavTransfer);
            this.panelSidebar.Controls.Add(this.btnNavDebitCard);
            this.panelSidebar.Controls.Add(this.btnNavLoan);
            this.panelSidebar.Controls.Add(this.btnNavAdminReq);
            this.panelSidebar.Controls.Add(this.btnNavBalance);
            this.panelSidebar.Controls.Add(this.btnNavBankStmt);
            this.panelSidebar.Controls.Add(this.btnNavLogout);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // pictureBoxSidebarLogo
            // 
            this.pictureBoxSidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSidebarLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSidebarLogo.Image")));
            this.pictureBoxSidebarLogo.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxSidebarLogo.Name = "pictureBoxSidebarLogo";
            this.pictureBoxSidebarLogo.Size = new System.Drawing.Size(180, 96);
            this.pictureBoxSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSidebarLogo.TabIndex = 10;
            this.pictureBoxSidebarLogo.TabStop = false;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(220, 48);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "  ⊞  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavTransfer
            // 
            this.btnNavTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransfer.FlatAppearance.BorderSize = 0;
            this.btnNavTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransfer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavTransfer.ForeColor = System.Drawing.Color.White;
            this.btnNavTransfer.Location = new System.Drawing.Point(0, 252);
            this.btnNavTransfer.Name = "btnNavTransfer";
            this.btnNavTransfer.Size = new System.Drawing.Size(220, 48);
            this.btnNavTransfer.TabIndex = 3;
            this.btnNavTransfer.Text = "  →  Transfer";
            this.btnNavTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransfer.UseVisualStyleBackColor = false;
            this.btnNavTransfer.Click += new System.EventHandler(this.btnNavTransfer_Click);
            // 
            // btnNavDebitCard
            // 
            this.btnNavDebitCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavDebitCard.BackColor = System.Drawing.Color.Transparent;
            this.btnNavDebitCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDebitCard.FlatAppearance.BorderSize = 0;
            this.btnNavDebitCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDebitCard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavDebitCard.ForeColor = System.Drawing.Color.White;
            this.btnNavDebitCard.Location = new System.Drawing.Point(0, 304);
            this.btnNavDebitCard.Name = "btnNavDebitCard";
            this.btnNavDebitCard.Size = new System.Drawing.Size(220, 48);
            this.btnNavDebitCard.TabIndex = 4;
            this.btnNavDebitCard.Text = "  💳  Debit Card";
            this.btnNavDebitCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDebitCard.UseVisualStyleBackColor = false;
            this.btnNavDebitCard.Click += new System.EventHandler(this.btnNavDebitCard_Click);
            // 
            // btnNavLoan
            // 
            this.btnNavLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavLoan.BackColor = System.Drawing.Color.Transparent;
            this.btnNavLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLoan.FlatAppearance.BorderSize = 0;
            this.btnNavLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavLoan.ForeColor = System.Drawing.Color.White;
            this.btnNavLoan.Location = new System.Drawing.Point(0, 356);
            this.btnNavLoan.Name = "btnNavLoan";
            this.btnNavLoan.Size = new System.Drawing.Size(220, 48);
            this.btnNavLoan.TabIndex = 5;
            this.btnNavLoan.Text = "  🏦  Apply Loan";
            this.btnNavLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLoan.UseVisualStyleBackColor = false;
            this.btnNavLoan.Click += new System.EventHandler(this.btnNavLoan_Click);
            // 
            // btnNavAdminReq
            // 
            this.btnNavAdminReq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavAdminReq.BackColor = System.Drawing.Color.Transparent;
            this.btnNavAdminReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAdminReq.FlatAppearance.BorderSize = 0;
            this.btnNavAdminReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAdminReq.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavAdminReq.ForeColor = System.Drawing.Color.White;
            this.btnNavAdminReq.Location = new System.Drawing.Point(0, 408);
            this.btnNavAdminReq.Name = "btnNavAdminReq";
            this.btnNavAdminReq.Size = new System.Drawing.Size(220, 48);
            this.btnNavAdminReq.TabIndex = 6;
            this.btnNavAdminReq.Text = "  🔑  Become Admin";
            this.btnNavAdminReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAdminReq.UseVisualStyleBackColor = false;
            this.btnNavAdminReq.Click += new System.EventHandler(this.btnNavAdminReq_Click);
            // 
            // btnNavBalance
            // 
            this.btnNavBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBalance.FlatAppearance.BorderSize = 0;
            this.btnNavBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBalance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavBalance.ForeColor = System.Drawing.Color.White;
            this.btnNavBalance.Location = new System.Drawing.Point(0, 460);
            this.btnNavBalance.Name = "btnNavBalance";
            this.btnNavBalance.Size = new System.Drawing.Size(220, 48);
            this.btnNavBalance.TabIndex = 7;
            this.btnNavBalance.Text = "   💰  Deposit Money";
            this.btnNavBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBalance.UseVisualStyleBackColor = false;
            this.btnNavBalance.Click += new System.EventHandler(this.btnNavBalance_Click);
            // 
            // btnNavBankStmt
            // 
            this.btnNavBankStmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavBankStmt.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBankStmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBankStmt.FlatAppearance.BorderSize = 0;
            this.btnNavBankStmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBankStmt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavBankStmt.ForeColor = System.Drawing.Color.White;
            this.btnNavBankStmt.Location = new System.Drawing.Point(0, 512);
            this.btnNavBankStmt.Name = "btnNavBankStmt";
            this.btnNavBankStmt.Size = new System.Drawing.Size(220, 48);
            this.btnNavBankStmt.TabIndex = 8;
            this.btnNavBankStmt.Text = "  📄  Bank Statement";
            this.btnNavBankStmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBankStmt.UseVisualStyleBackColor = false;
            this.btnNavBankStmt.Click += new System.EventHandler(this.btnNavBankStmt_Click);
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnNavLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavLogout.ForeColor = System.Drawing.Color.White;
            this.btnNavLogout.Location = new System.Drawing.Point(0, 564);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(220, 48);
            this.btnNavLogout.TabIndex = 9;
            this.btnNavLogout.Text = "  ↩  Logout";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = false;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panelContent.Controls.Add(this.lblPageTitle);
            this.panelContent.Controls.Add(this.lblPageSubtitle);
            this.panelContent.Controls.Add(this.lblInfo);
            this.panelContent.Controls.Add(this.btnApply);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.panelCardDetails);
            this.panelContent.Location = new System.Drawing.Point(220, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1060, 720);
            this.panelContent.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.lblPageTitle.Location = new System.Drawing.Point(30, 30);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(800, 44);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Debit Card";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPageSubtitle.Location = new System.Drawing.Point(30, 76);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(800, 24);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Apply for a NovaBank debit card";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.lblInfo.Location = new System.Drawing.Point(30, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(700, 28);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Applying for a debit card costs Rs. 500 deducted from your balance.";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(30, 162);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(280, 52);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply for Debit Card";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(30, 234);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(600, 28);
            this.lblStatus.TabIndex = 4;
            // 
            // panelCardDetails
            // 
            this.panelCardDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panelCardDetails.Controls.Add(this.lblCardNumber);
            this.panelCardDetails.Controls.Add(this.lblCardHolder);
            this.panelCardDetails.Controls.Add(this.lblCardExpiry);
            this.panelCardDetails.Controls.Add(this.pictureBoxCardLogo);
            this.panelCardDetails.Location = new System.Drawing.Point(30, 280);
            this.panelCardDetails.Name = "panelCardDetails";
            this.panelCardDetails.Size = new System.Drawing.Size(500, 200);
            this.panelCardDetails.TabIndex = 5;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(20, 60);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(460, 40);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "**** **** **** ****";
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblCardHolder.Location = new System.Drawing.Point(20, 116);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(200, 22);
            this.lblCardHolder.TabIndex = 1;
            this.lblCardHolder.Text = "CARD HOLDER";
            // 
            // lblCardExpiry
            // 
            this.lblCardExpiry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblCardExpiry.Location = new System.Drawing.Point(320, 116);
            this.lblCardExpiry.Name = "lblCardExpiry";
            this.lblCardExpiry.Size = new System.Drawing.Size(160, 22);
            this.lblCardExpiry.TabIndex = 2;
            this.lblCardExpiry.Text = "EXP: MM/YY";
            // 
            // pictureBoxCardLogo
            // 
            this.pictureBoxCardLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCardLogo.Location = new System.Drawing.Point(380, 16);
            this.pictureBoxCardLogo.Name = "pictureBoxCardLogo";
            this.pictureBoxCardLogo.Size = new System.Drawing.Size(100, 40);
            this.pictureBoxCardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCardLogo.TabIndex = 3;
            this.pictureBoxCardLogo.TabStop = false;
            // 
            // CustomerApplyDebitCardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerApplyDebitCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaBank - CustomerApplyDebitCard";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSidebarLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelCardDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardLogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavTransfer;
        private System.Windows.Forms.Button btnNavDebitCard;
        private System.Windows.Forms.Button btnNavLoan;
        private System.Windows.Forms.Button btnNavAdminReq;
        private System.Windows.Forms.Button btnNavBalance;
        private System.Windows.Forms.Button btnNavBankStmt;
        private System.Windows.Forms.Button btnNavLogout;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Label lblPageTitle, lblPageSubtitle, lblInfo, lblStatus, lblCardNumber, lblCardHolder, lblCardExpiry;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panelCardDetails;
        private System.Windows.Forms.PictureBox pictureBoxCardLogo;
        private System.Windows.Forms.PictureBox pictureBoxSidebarLogo;
    }
}
