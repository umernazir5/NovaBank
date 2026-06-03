namespace BankUI
{
    partial class AdminBankStatementForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBankStatementForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavTransactions = new System.Windows.Forms.Button();
            this.btnNavLoans = new System.Windows.Forms.Button();
            this.btnNavAdminReq = new System.Windows.Forms.Button();
            this.btnNavDebitCard = new System.Windows.Forms.Button();
            this.btnNavBankStmt = new System.Windows.Forms.Button();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblUsr = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvStatement = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.pictureBoxSidebarLogo = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panelSidebar.Controls.Add(this.pictureBoxSidebarLogo);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.btnNavUsers);
            this.panelSidebar.Controls.Add(this.btnNavTransactions);
            this.panelSidebar.Controls.Add(this.btnNavLoans);
            this.panelSidebar.Controls.Add(this.btnNavAdminReq);
            this.panelSidebar.Controls.Add(this.btnNavDebitCard);
            this.panelSidebar.Controls.Add(this.btnNavBankStmt);
            this.panelSidebar.Controls.Add(this.btnNavLogout);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 720);
            this.panelSidebar.TabIndex = 0;
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
            // btnNavUsers
            // 
            this.btnNavUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavUsers.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.Location = new System.Drawing.Point(0, 252);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(220, 48);
            this.btnNavUsers.TabIndex = 3;
            this.btnNavUsers.Text = "  👥  Users";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.btnNavUsers_Click);
            // 
            // btnNavTransactions
            // 
            this.btnNavTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransactions.FlatAppearance.BorderSize = 0;
            this.btnNavTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransactions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavTransactions.ForeColor = System.Drawing.Color.White;
            this.btnNavTransactions.Location = new System.Drawing.Point(0, 304);
            this.btnNavTransactions.Name = "btnNavTransactions";
            this.btnNavTransactions.Size = new System.Drawing.Size(220, 48);
            this.btnNavTransactions.TabIndex = 4;
            this.btnNavTransactions.Text = "  💳  Transactions";
            this.btnNavTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransactions.UseVisualStyleBackColor = false;
            this.btnNavTransactions.Click += new System.EventHandler(this.btnNavTransactions_Click);
            // 
            // btnNavLoans
            // 
            this.btnNavLoans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavLoans.BackColor = System.Drawing.Color.Transparent;
            this.btnNavLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLoans.FlatAppearance.BorderSize = 0;
            this.btnNavLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLoans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavLoans.ForeColor = System.Drawing.Color.White;
            this.btnNavLoans.Location = new System.Drawing.Point(0, 356);
            this.btnNavLoans.Name = "btnNavLoans";
            this.btnNavLoans.Size = new System.Drawing.Size(220, 48);
            this.btnNavLoans.TabIndex = 5;
            this.btnNavLoans.Text = "  🏦  Loan Requests";
            this.btnNavLoans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLoans.UseVisualStyleBackColor = false;
            this.btnNavLoans.Click += new System.EventHandler(this.btnNavLoans_Click);
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
            this.btnNavAdminReq.Text = "  🔑  Admin Requests";
            this.btnNavAdminReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAdminReq.UseVisualStyleBackColor = false;
            this.btnNavAdminReq.Click += new System.EventHandler(this.btnNavAdminReq_Click);
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
            this.btnNavDebitCard.Location = new System.Drawing.Point(0, 460);
            this.btnNavDebitCard.Name = "btnNavDebitCard";
            this.btnNavDebitCard.Size = new System.Drawing.Size(220, 48);
            this.btnNavDebitCard.TabIndex = 7;
            this.btnNavDebitCard.Text = "  💳  Debit Cards";
            this.btnNavDebitCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDebitCard.UseVisualStyleBackColor = false;
            this.btnNavDebitCard.Click += new System.EventHandler(this.btnNavDebitCard_Click);
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
            this.panelContent.Controls.Add(this.lblUsr);
            this.panelContent.Controls.Add(this.txtUsername);
            this.panelContent.Controls.Add(this.lblFrom);
            this.panelContent.Controls.Add(this.dtpFrom);
            this.panelContent.Controls.Add(this.lblTo);
            this.panelContent.Controls.Add(this.dtpTo);
            this.panelContent.Controls.Add(this.btnGenerate);
            this.panelContent.Controls.Add(this.dgvStatement);
            this.panelContent.Controls.Add(this.btnExport);
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
            this.lblPageTitle.Text = "Bank Statement (Admin)";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPageSubtitle.Location = new System.Drawing.Point(30, 76);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(800, 24);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Generate statement for any user";
            // 
            // lblUsr
            // 
            this.lblUsr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUsr.Location = new System.Drawing.Point(30, 110);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(90, 28);
            this.lblUsr.TabIndex = 2;
            this.lblUsr.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(126, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 32);
            this.txtUsername.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFrom.Location = new System.Drawing.Point(390, 110);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 28);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFrom.Location = new System.Drawing.Point(450, 110);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(170, 30);
            this.dtpFrom.TabIndex = 5;
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTo.Location = new System.Drawing.Point(636, 110);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 28);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTo.Location = new System.Drawing.Point(674, 110);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(170, 30);
            this.dtpTo.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(860, 108);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 36);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvStatement
            // 
            this.dgvStatement.AllowUserToAddRows = false;
            this.dgvStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatement.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatement.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatement.Location = new System.Drawing.Point(30, 164);
            this.dgvStatement.Name = "dgvStatement";
            this.dgvStatement.ReadOnly = true;
            this.dgvStatement.RowHeadersVisible = false;
            this.dgvStatement.RowHeadersWidth = 51;
            this.dgvStatement.Size = new System.Drawing.Size(990, 440);
            this.dgvStatement.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(30, 624);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 44);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pictureBoxSidebarLogo
            // 
            this.pictureBoxSidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSidebarLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSidebarLogo.Image")));
            this.pictureBoxSidebarLogo.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxSidebarLogo.Name = "pictureBoxSidebarLogo";
            this.pictureBoxSidebarLogo.Size = new System.Drawing.Size(180, 92);
            this.pictureBoxSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSidebarLogo.TabIndex = 10;
            this.pictureBoxSidebarLogo.TabStop = false;
            // 
            // AdminBankStatementForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminBankStatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaBank - AdminBankStatement";
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSidebarLogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavTransactions;
        private System.Windows.Forms.Button btnNavLoans;
        private System.Windows.Forms.Button btnNavAdminReq;
        private System.Windows.Forms.Button btnNavDebitCard;
        private System.Windows.Forms.Button btnNavBankStmt;
        private System.Windows.Forms.Button btnNavLogout;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Label lblPageTitle, lblPageSubtitle, lblUsr, lblFrom, lblTo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DateTimePicker dtpFrom, dtpTo;
        private System.Windows.Forms.Button btnGenerate, btnExport;
        private System.Windows.Forms.DataGridView dgvStatement;
        private System.Windows.Forms.PictureBox pictureBoxSidebarLogo;
    }
}
