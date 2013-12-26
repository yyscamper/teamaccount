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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lstViewMembers = new System.Windows.Forms.ListView();
            this.colMemberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMemberExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSeperator = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxPayer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxPlace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewHistory = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMembers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lstViewMembers);
            this.groupInput.Controls.Add(this.labelSeperator);
            this.groupInput.Controls.Add(this.btnAdd);
            this.groupInput.Controls.Add(this.btnClear);
            this.groupInput.Controls.Add(this.txtboxComment);
            this.groupInput.Controls.Add(this.timePicker);
            this.groupInput.Controls.Add(this.cmbBoxPayer);
            this.groupInput.Controls.Add(this.label5);
            this.groupInput.Controls.Add(this.label6);
            this.groupInput.Controls.Add(this.label3);
            this.groupInput.Controls.Add(this.cmbBoxPlace);
            this.groupInput.Controls.Add(this.label4);
            this.groupInput.Controls.Add(this.label2);
            this.groupInput.Controls.Add(this.txtboxMoney);
            this.groupInput.Controls.Add(this.label1);
            this.groupInput.Location = new System.Drawing.Point(589, 0);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(431, 389);
            this.groupInput.TabIndex = 0;
            this.groupInput.TabStop = false;
            // 
            // lstViewMembers
            // 
            this.lstViewMembers.CheckBoxes = true;
            this.lstViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMemberName,
            this.colMemberExpense});
            this.lstViewMembers.FullRowSelect = true;
            this.lstViewMembers.Location = new System.Drawing.Point(233, 38);
            this.lstViewMembers.Name = "lstViewMembers";
            this.lstViewMembers.Size = new System.Drawing.Size(190, 293);
            this.lstViewMembers.TabIndex = 11;
            this.lstViewMembers.UseCompatibleStateImageBehavior = false;
            this.lstViewMembers.View = System.Windows.Forms.View.Details;
            // 
            // colMemberName
            // 
            this.colMemberName.Text = "Name";
            this.colMemberName.Width = 90;
            // 
            // colMemberExpense
            // 
            this.colMemberExpense.Text = "Expense";
            this.colMemberExpense.Width = 90;
            // 
            // labelSeperator
            // 
            this.labelSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeperator.Font = new System.Drawing.Font("微软雅黑", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSeperator.Location = new System.Drawing.Point(6, 339);
            this.labelSeperator.Name = "labelSeperator";
            this.labelSeperator.Size = new System.Drawing.Size(417, 4);
            this.labelSeperator.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtboxComment
            // 
            this.txtboxComment.Location = new System.Drawing.Point(7, 169);
            this.txtboxComment.Multiline = true;
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(217, 162);
            this.txtboxComment.TabIndex = 6;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(67, 55);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(157, 23);
            this.timePicker.TabIndex = 4;
            // 
            // cmbBoxPayer
            // 
            this.cmbBoxPayer.FormattingEnabled = true;
            this.cmbBoxPayer.Location = new System.Drawing.Point(67, 116);
            this.cmbBoxPayer.Name = "cmbBoxPayer";
            this.cmbBoxPayer.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxPayer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Members:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Comment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payer:";
            // 
            // cmbBoxPlace
            // 
            this.cmbBoxPlace.FormattingEnabled = true;
            this.cmbBoxPlace.Location = new System.Drawing.Point(67, 85);
            this.cmbBoxPlace.Name = "cmbBoxPlace";
            this.cmbBoxPlace.Size = new System.Drawing.Size(157, 25);
            this.cmbBoxPlace.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Place:";
            // 
            // txtboxMoney
            // 
            this.txtboxMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtboxMoney.Location = new System.Drawing.Point(67, 18);
            this.txtboxMoney.Name = "txtboxMoney";
            this.txtboxMoney.Size = new System.Drawing.Size(157, 29);
            this.txtboxMoney.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money:";
            // 
            // lstViewHistory
            // 
            this.lstViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colMoney,
            this.colPlace,
            this.colPayer,
            this.colMembers});
            this.lstViewHistory.Location = new System.Drawing.Point(8, 8);
            this.lstViewHistory.Name = "lstViewHistory";
            this.lstViewHistory.Size = new System.Drawing.Size(575, 450);
            this.lstViewHistory.TabIndex = 1;
            this.lstViewHistory.UseCompatibleStateImageBehavior = false;
            this.lstViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 120;
            // 
            // colMoney
            // 
            this.colMoney.Text = "Money";
            this.colMoney.Width = 80;
            // 
            // colPlace
            // 
            this.colPlace.Text = "Place";
            this.colPlace.Width = 80;
            // 
            // colPayer
            // 
            this.colPayer.Text = "Payer";
            this.colPayer.Width = 80;
            // 
            // colMembers
            // 
            this.colMembers.Text = "Members";
            this.colMembers.Width = 240;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 646);
            this.Controls.Add(this.lstViewHistory);
            this.Controls.Add(this.groupInput);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Team Account";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.ListView lstViewHistory;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelSeperator;
        private System.Windows.Forms.ListView lstViewMembers;
        private System.Windows.Forms.ColumnHeader colMemberName;
        private System.Windows.Forms.ColumnHeader colMemberExpense;
    }
}

