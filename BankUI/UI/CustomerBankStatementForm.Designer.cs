namespace BankUI
{
    partial class CustomerBankStatementForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBankStatementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvStatement = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panelSidebar.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.panelContent.Controls.Add(this.lblFrom);
            this.panelContent.Controls.Add(this.dtpFrom);
            this.panelContent.Controls.Add(this.lblTo);
            this.panelContent.Controls.Add(this.dtpTo);
            this.panelContent.Controls.Add(this.btnView);
            this.panelContent.Controls.Add(this.dgvStatement);
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
            this.lblPageTitle.Text = "Bank Statement";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPageSubtitle.Location = new System.Drawing.Point(30, 76);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(800, 24);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "View your transaction history";
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFrom.Location = new System.Drawing.Point(30, 110);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 28);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFrom.Location = new System.Drawing.Point(96, 110);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(180, 30);
            this.dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTo.Location = new System.Drawing.Point(292, 110);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 28);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTo.Location = new System.Drawing.Point(338, 110);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(180, 30);
            this.dtpTo.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(536, 108);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(180, 36);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View Statement";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.dgvStatement.Location = new System.Drawing.Point(30, 162);
            this.dgvStatement.Name = "dgvStatement";
            this.dgvStatement.ReadOnly = true;
            this.dgvStatement.RowHeadersVisible = false;
            this.dgvStatement.RowHeadersWidth = 51;
            this.dgvStatement.Size = new System.Drawing.Size(990, 510);
            this.dgvStatement.TabIndex = 7;
            // 
            // CustomerBankStatementForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerBankStatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaBank - CustomerBankStatement";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).EndInit();
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

        private System.Windows.Forms.Label lblPageTitle, lblPageSubtitle, lblFrom, lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom, dtpTo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvStatement;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
