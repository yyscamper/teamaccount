namespace TeamAccount
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lstViewMembers = new System.Windows.Forms.ListView();
            this.colSelectMembers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddOrEditPayEntry = new System.Windows.Forms.Button();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxPayer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxPlace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewPayEntriesHome = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMembers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxMenuPayEntriesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuEditPayEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDeletePayEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTxtBoxDashboard = new System.Windows.Forms.RichTextBox();
            this.tabPageExpense = new System.Windows.Forms.TabPage();
            this.lstViewExpenseReport = new System.Windows.Forms.ListView();
            this.colExpenseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpenseExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpenseAttendCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpensePayCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpensePaySum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageP2PDebet = new System.Windows.Forms.TabPage();
            this.lstViewP2PDebet = new System.Windows.Forms.ListView();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.groupInput.SuspendLayout();
            this.ctxMenuPayEntriesList.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageExpense.SuspendLayout();
            this.tabPageP2PDebet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lstViewMembers);
            this.groupInput.Controls.Add(this.btnAddOrEditPayEntry);
            this.groupInput.Controls.Add(this.txtboxComment);
            this.groupInput.Controls.Add(this.timePicker);
            this.groupInput.Controls.Add(this.cmbBoxPayer);
            this.groupInput.Controls.Add(this.label6);
            this.groupInput.Controls.Add(this.label3);
            this.groupInput.Controls.Add(this.cmbBoxPlace);
            this.groupInput.Controls.Add(this.label4);
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.txtboxMoney);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Location = new System.Drawing.Point(412, 3);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(388, 330);
            this.groupInput.TabIndex = 0;
            this.groupInput.TabStop = false;
            // 
            // lstViewMembers
            // 
            this.lstViewMembers.CheckBoxes = true;
            this.lstViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSelectMembers});
            this.lstViewMembers.FullRowSelect = true;
            this.lstViewMembers.Location = new System.Drawing.Point(232, 16);
            this.lstViewMembers.Name = "lstViewMembers";
            this.lstViewMembers.Size = new System.Drawing.Size(150, 261);
            this.lstViewMembers.TabIndex = 11;
            this.lstViewMembers.UseCompatibleStateImageBehavior = false;
            this.lstViewMembers.View = System.Windows.Forms.View.Details;
            this.lstViewMembers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstViewMembers_ItemChecked);
            this.lstViewMembers.SelectedIndexChanged += new System.EventHandler(this.lstViewMembers_SelectedIndexChanged);
            // 
            // colSelectMembers
            // 
            this.colSelectMembers.Text = "Select Members:";
            this.colSelectMembers.Width = 146;
            // 
            // btnAddOrEditPayEntry
            // 
            this.btnAddOrEditPayEntry.Location = new System.Drawing.Point(232, 283);
            this.btnAddOrEditPayEntry.Name = "btnAddOrEditPayEntry";
            this.btnAddOrEditPayEntry.Size = new System.Drawing.Size(150, 38);
            this.btnAddOrEditPayEntry.TabIndex = 7;
            this.btnAddOrEditPayEntry.Text = "Add";
            this.btnAddOrEditPayEntry.UseVisualStyleBackColor = true;
            this.btnAddOrEditPayEntry.Click += new System.EventHandler(this.btnAddOrEditPayEntry_Click);
            // 
            // txtboxComment
            // 
            this.txtboxComment.Location = new System.Drawing.Point(7, 185);
            this.txtboxComment.Multiline = true;
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(217, 139);
            this.txtboxComment.TabIndex = 6;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(67, 73);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(157, 23);
            this.timePicker.TabIndex = 4;
            // 
            // cmbBoxPayer
            // 
            this.cmbBoxPayer.FormattingEnabled = true;
            this.cmbBoxPayer.Location = new System.Drawing.Point(67, 136);
            this.cmbBoxPayer.Name = "cmbBoxPayer";
            this.cmbBoxPayer.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxPayer.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Comment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payer:";
            // 
            // cmbBoxPlace
            // 
            this.cmbBoxPlace.FormattingEnabled = true;
            this.cmbBoxPlace.Location = new System.Drawing.Point(67, 104);
            this.cmbBoxPlace.Name = "cmbBoxPlace";
            this.cmbBoxPlace.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxPlace.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Place:";
            // 
            // txtboxMoney
            // 
            this.txtboxMoney.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxMoney.Location = new System.Drawing.Point(67, 16);
            this.txtboxMoney.MinimumSize = new System.Drawing.Size(4, 48);
            this.txtboxMoney.Multiline = true;
            this.txtboxMoney.Name = "txtboxMoney";
            this.txtboxMoney.Size = new System.Drawing.Size(157, 48);
            this.txtboxMoney.TabIndex = 2;
            this.txtboxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money:";
            // 
            // lstViewPayEntriesHome
            // 
            this.lstViewPayEntriesHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colMoney,
            this.colPlace,
            this.colPayer,
            this.colMembers});
            this.lstViewPayEntriesHome.ContextMenuStrip = this.ctxMenuPayEntriesList;
            this.lstViewPayEntriesHome.FullRowSelect = true;
            this.lstViewPayEntriesHome.Location = new System.Drawing.Point(6, 341);
            this.lstViewPayEntriesHome.Name = "lstViewPayEntriesHome";
            this.lstViewPayEntriesHome.Size = new System.Drawing.Size(791, 258);
            this.lstViewPayEntriesHome.TabIndex = 1;
            this.lstViewPayEntriesHome.UseCompatibleStateImageBehavior = false;
            this.lstViewPayEntriesHome.View = System.Windows.Forms.View.Details;
            this.lstViewPayEntriesHome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstViewPayEntriesHome_KeyDown);
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 128;
            // 
            // colMoney
            // 
            this.colMoney.Text = "Money";
            this.colMoney.Width = 100;
            // 
            // colPlace
            // 
            this.colPlace.Text = "Place";
            this.colPlace.Width = 100;
            // 
            // colPayer
            // 
            this.colPayer.Text = "Payer";
            this.colPayer.Width = 100;
            // 
            // colMembers
            // 
            this.colMembers.Text = "Members";
            this.colMembers.Width = 480;
            // 
            // ctxMenuPayEntriesList
            // 
            this.ctxMenuPayEntriesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuEditPayEntry,
            this.subMenuDeletePayEntry});
            this.ctxMenuPayEntriesList.Name = "contextMenuStrip1";
            this.ctxMenuPayEntriesList.Size = new System.Drawing.Size(114, 48);
            this.ctxMenuPayEntriesList.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuPayEntriesList_Opening);
            this.ctxMenuPayEntriesList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxMenuPayEntriesList_ItemClicked);
            // 
            // subMenuEditPayEntry
            // 
            this.subMenuEditPayEntry.Name = "subMenuEditPayEntry";
            this.subMenuEditPayEntry.Size = new System.Drawing.Size(113, 22);
            this.subMenuEditPayEntry.Text = "Edit";
            // 
            // subMenuDeletePayEntry
            // 
            this.subMenuDeletePayEntry.Name = "subMenuDeletePayEntry";
            this.subMenuDeletePayEntry.Size = new System.Drawing.Size(113, 22);
            this.subMenuDeletePayEntry.Text = "Delete";
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPageHome);
            this.tabCtrlMain.Controls.Add(this.tabPageExpense);
            this.tabCtrlMain.Controls.Add(this.tabPageP2PDebet);
            this.tabCtrlMain.Controls.Add(this.tabPageHistory);
            this.tabCtrlMain.Location = new System.Drawing.Point(-1, -1);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(811, 635);
            this.tabCtrlMain.TabIndex = 2;
            this.tabCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrlMain_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.groupBox1);
            this.tabPageHome.Controls.Add(this.lstViewPayEntriesHome);
            this.tabPageHome.Controls.Add(this.groupInput);
            this.tabPageHome.Location = new System.Drawing.Point(4, 26);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(803, 605);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTxtBoxDashboard);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // richTxtBoxDashboard
            // 
            this.richTxtBoxDashboard.Location = new System.Drawing.Point(6, 16);
            this.richTxtBoxDashboard.Name = "richTxtBoxDashboard";
            this.richTxtBoxDashboard.Size = new System.Drawing.Size(388, 310);
            this.richTxtBoxDashboard.TabIndex = 0;
            this.richTxtBoxDashboard.Text = "";
            // 
            // tabPageExpense
            // 
            this.tabPageExpense.Controls.Add(this.lstViewExpenseReport);
            this.tabPageExpense.Location = new System.Drawing.Point(4, 26);
            this.tabPageExpense.Name = "tabPageExpense";
            this.tabPageExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpense.Size = new System.Drawing.Size(803, 605);
            this.tabPageExpense.TabIndex = 2;
            this.tabPageExpense.Text = "Expense";
            this.tabPageExpense.UseVisualStyleBackColor = true;
            // 
            // lstViewExpenseReport
            // 
            this.lstViewExpenseReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExpenseName,
            this.colExpenseExpense,
            this.colExpenseAttendCount,
            this.colExpensePayCount,
            this.colExpensePaySum});
            this.lstViewExpenseReport.FullRowSelect = true;
            this.lstViewExpenseReport.Location = new System.Drawing.Point(6, 6);
            this.lstViewExpenseReport.Name = "lstViewExpenseReport";
            this.lstViewExpenseReport.Size = new System.Drawing.Size(467, 328);
            this.lstViewExpenseReport.TabIndex = 0;
            this.lstViewExpenseReport.UseCompatibleStateImageBehavior = false;
            this.lstViewExpenseReport.View = System.Windows.Forms.View.Details;
            // 
            // colExpenseName
            // 
            this.colExpenseName.Text = "Name";
            this.colExpenseName.Width = 100;
            // 
            // colExpenseExpense
            // 
            this.colExpenseExpense.Text = "Expense";
            this.colExpenseExpense.Width = 80;
            // 
            // colExpenseAttendCount
            // 
            this.colExpenseAttendCount.Text = "AttendCount";
            this.colExpenseAttendCount.Width = 100;
            // 
            // colExpensePayCount
            // 
            this.colExpensePayCount.Text = "PayCount";
            this.colExpensePayCount.Width = 80;
            // 
            // colExpensePaySum
            // 
            this.colExpensePaySum.Text = "PaySum";
            this.colExpensePaySum.Width = 100;
            // 
            // tabPageP2PDebet
            // 
            this.tabPageP2PDebet.Controls.Add(this.lstViewP2PDebet);
            this.tabPageP2PDebet.Location = new System.Drawing.Point(4, 26);
            this.tabPageP2PDebet.Name = "tabPageP2PDebet";
            this.tabPageP2PDebet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageP2PDebet.Size = new System.Drawing.Size(803, 605);
            this.tabPageP2PDebet.TabIndex = 1;
            this.tabPageP2PDebet.Text = "P2P Debet";
            this.tabPageP2PDebet.UseVisualStyleBackColor = true;
            // 
            // lstViewP2PDebet
            // 
            this.lstViewP2PDebet.FullRowSelect = true;
            this.lstViewP2PDebet.GridLines = true;
            this.lstViewP2PDebet.Location = new System.Drawing.Point(6, 6);
            this.lstViewP2PDebet.Name = "lstViewP2PDebet";
            this.lstViewP2PDebet.Size = new System.Drawing.Size(791, 429);
            this.lstViewP2PDebet.TabIndex = 0;
            this.lstViewP2PDebet.UseCompatibleStateImageBehavior = false;
            this.lstViewP2PDebet.View = System.Windows.Forms.View.Details;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 26);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Size = new System.Drawing.Size(803, 605);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 646);
            this.Controls.Add(this.tabCtrlMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Team Account";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.ctxMenuPayEntriesList.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageExpense.ResumeLayout(false);
            this.tabPageP2PDebet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.ListView lstViewPayEntriesHome;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colMoney;
        private System.Windows.Forms.ColumnHeader colPlace;
        private System.Windows.Forms.ColumnHeader colPayer;
        private System.Windows.Forms.ColumnHeader colMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxMoney;
        private System.Windows.Forms.ComboBox cmbBoxPayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddOrEditPayEntry;
        private System.Windows.Forms.ListView lstViewMembers;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageP2PDebet;
        private System.Windows.Forms.TabPage tabPageExpense;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTxtBoxDashboard;
        private System.Windows.Forms.ListView lstViewExpenseReport;
        private System.Windows.Forms.ColumnHeader colExpenseName;
        private System.Windows.Forms.ColumnHeader colExpenseExpense;
        private System.Windows.Forms.ColumnHeader colExpenseAttendCount;
        private System.Windows.Forms.ColumnHeader colExpensePayCount;
        private System.Windows.Forms.ColumnHeader colExpensePaySum;
        private System.Windows.Forms.ListView lstViewP2PDebet;
        private System.Windows.Forms.ColumnHeader colSelectMembers;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPayEntriesList;
        private System.Windows.Forms.ToolStripMenuItem subMenuEditPayEntry;
        private System.Windows.Forms.ToolStripMenuItem subMenuDeletePayEntry;
    }
}

