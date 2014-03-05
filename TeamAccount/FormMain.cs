using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAccount
{
    public partial class FormMain : Form
    {
        private AccountBook _accountBook = null;
        private bool _payEntryAddMode = true;
        private PayEntry _currEditPayEntry = null;
        private ListViewItem _currEditPayEntryView = null;

        public FormMain()
        {
            InitializeComponent();

            _accountBook = new AccountBook();
            lstViewMembers.MultiSelect = true;
            
            lstViewPayEntriesHome.FullRowSelect = true;
            lstViewMembers.FullRowSelect = true;

            ImageList imgLst = new ImageList();
            imgLst.ImageSize = new Size(1, 20);
            lstViewMembers.SmallImageList = imgLst;
            
            ImageList imgLst2 = new ImageList();
            imgLst2.ImageSize = new Size(1, 24);
            lstViewP2PDebet.SmallImageList = imgLst2;
            lstViewExpenseReport.SmallImageList = imgLst2;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _accountBook.OpenFile("./data/accountbook.txt");
            }
            catch
            {
                yMessageBox.ShowError("Open account book file failed!");
            }

            cmbBoxPlace.Items.AddRange(_accountBook.AllPlaces);
            RefreshAllPersonsName();
            RefreshPayEntryHistoryView();
            RefreshMembersView();
        }

        private PayEntry GetInputEntry()
        {
            PayPerson payer = _accountBook.GetPerson(cmbBoxPayer.Text);
            if (payer == null)
            {
                yMessageBox.ShowError("The payer's name is not correct!", "Input Error");
                return null;
            }

            List<PayPerson> lstMems = new List<PayPerson>();
            for (int i = 0; i < lstViewMembers.Items.Count; i++)
            {
                if (!lstViewMembers.Items[i].Checked)
                    continue;

                PayPerson p = _accountBook.GetPerson(lstViewMembers.Items[i].SubItems[0].Text);
                if (p == null)
                {
                    yMessageBox.ShowError("The members's name is not correct!", "Input Error");
                    return null;
                }
                lstMems.Add(p);
            }

            PayPerson[] members = new PayPerson[lstMems.Count];
            lstMems.CopyTo(members);

            double money;
            try
            {
                money = double.Parse(txtboxMoney.Text);
            }
            catch
            {
                yMessageBox.ShowError("Your input money format is not correct!", "Input Error");
                return null;
            }

            PayEntry entry = new PayEntry();
            entry.Money = money;
            entry.Payer = payer;
            entry.Members = members;
            entry.Time = timePicker.Value;
            entry.Place = cmbBoxPlace.Text;
            entry.Comment = txtboxComment.Text;

            return entry;
        }



        private void btnAddOrEditPayEntry_Click(object sender, EventArgs e)
        {
            PayEntry entry = GetInputEntry();
                if (entry == null)
                    return;

            if (_payEntryAddMode)
            {
                _accountBook.AddPayEntry(entry);
                AddOnePayEntryView(entry);
            }
            else
            {
                if (_currEditPayEntryView != null && _currEditPayEntry != null)
                {
                    _accountBook.EditPayEntry(_currEditPayEntry, entry);
                    UpdateOnePayEntryView(_currEditPayEntry, _currEditPayEntryView);
                    _currEditPayEntryView.BackColor = Color.White;
                    _payEntryAddMode = true;
                    btnAddOrEditPayEntry.Text = "Add";
                    _currEditPayEntryView = null;
                    _currEditPayEntry = null;
                }
            }
        }

        private void UpdateOnePayEntryView(PayEntry entry, ListViewItem lvi)
        {
            lvi.SubItems.Clear();
            //lvi.SubItems.Add(string.Empty);
            lvi.SubItems[0].Text = entry.Time.ToString("yyyy/MM/dd hh:mm");
            lvi.SubItems.Add(entry.Money.ToString("F1"));
            lvi.SubItems.Add(entry.Place);
            lvi.SubItems.Add(entry.Payer.Name);


            StringBuilder sb = new StringBuilder();
            foreach (PayPerson p in entry.Members)
            {
                sb.Append(p.Name);
                sb.Append(",");
            }
            if (sb.Length > 1)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            lvi.SubItems.Add(sb.ToString());
        }

        private void AddOnePayEntryView(PayEntry entry)
        {
            ListViewItem lvi = new ListViewItem();
            UpdateOnePayEntryView(entry, lvi);
            lstViewPayEntriesHome.Items.Add(lvi);
        }

        private void RefreshPayEntryHistoryView()
        {
            lstViewPayEntriesHome.Items.Clear();
            List<PayEntry> allEntries = _accountBook.AllPayEntries;
            foreach (PayEntry entry in allEntries)
            {
                AddOnePayEntryView(entry);
            }
        }

        private void RefreshMembersView()
        {
            lstViewMembers.Items.Clear();
            foreach (PayPerson p in _accountBook.AllPersons.Values)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = p.Name;
                lstViewMembers.Items.Add(lvi);
            }
        }

        private void RefreshExpenseReportView()
        {
            _accountBook.Calculate();
            lstViewExpenseReport.Items.Clear();
            foreach (PayPerson p in _accountBook.AllPersons.Values)
            {
                ListViewItem lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Expense.ToString("F1"));
                lvi.SubItems.Add(p.AttendCount.ToString());
                lvi.SubItems.Add(p.PayCount.ToString());
                lvi.SubItems.Add(p.PaySum.ToString("F1"));

                lstViewExpenseReport.Items.Add(lvi);
            }
        }

        public void RefreshAllPersonsName()
        {
            cmbBoxPayer.Items.Clear();

            foreach (string p in _accountBook.AllPersons.Keys)
            {
                cmbBoxPayer.Items.Add(p);
            }
        }

        private void lstViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabCtrlMain.SelectedIndex)
            {
                case 1:
                    RefreshExpenseReportView();
                    break;
                case 2:
                    RefreshP2PDebetTableView();
                    break;
                default:
                    break;
            }
        }

        private void RefreshP2PDebetTableView()
        {
            lstViewP2PDebet.Columns.Clear();
            lstViewP2PDebet.Items.Clear();

            ColumnHeader col = new ColumnHeader();
            col.Text = string.Empty;
            col.Width = 80;
            lstViewP2PDebet.Columns.Add(col);

            _accountBook.Calculate();
            double[,] p2pResult = _accountBook.P2PDebetTable;

            foreach (PayPerson p in _accountBook.AllPersons.Values)
            {
                col = new ColumnHeader();
                col.Text = p.Name;
                col.Width = 60;
                lstViewP2PDebet.Columns.Add(col);
            }

            foreach (PayPerson p in _accountBook.AllPersons.Values)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = p.Name + " →";
                lstViewP2PDebet.Items.Add(lvi);
                lvi.UseItemStyleForSubItems = false;
                for (int i = 0; i < _accountBook.AllPersons.Count; i++)
                {
                    double val = p2pResult[lvi.Index, i];
                    if (Math.Abs(val) > 0.01)
                        lvi.SubItems.Add(val.ToString("F1"));
                    else
                        lvi.SubItems.Add(string.Empty);

                    if (lvi.Index < i)
                    {
                        lvi.SubItems[i+1].BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void DeletePayEntryFromList()
        {
            if (lstViewPayEntriesHome.SelectedItems.Count <= 0)
                return;

            ListViewItem lvi = lstViewPayEntriesHome.SelectedItems[0];

            if (DialogResult.No == yMessageBox.ShowConfirm("Are you sure want to delete the entry at time " + lvi.SubItems[0].Text + "?", "Confirm Delete", null))
            {
                return;
            }
            _accountBook.RemovePayEntry(lvi.Index);
            lstViewPayEntriesHome.Items.Remove(lvi);
        }

        public void SetInputData(PayEntry entry)
        {
            txtboxMoney.Text = entry.Money.ToString();
            txtboxComment.Text = entry.Comment;
            cmbBoxPayer.Text = entry.Payer.Name;
            cmbBoxPlace.Text = entry.Place;
            timePicker.Value = entry.Time;

            foreach (ListViewItem itm in lstViewMembers.Items)
            {
                itm.Checked = false;

                foreach (PayPerson p in entry.Members)
                {
                    if (p.Name == itm.SubItems[0].Text)
                    {
                        itm.Checked = true;
                        break;
                    }
                }
            }
        }

        public void EditPayEntryAtList()
        {
            if (lstViewPayEntriesHome.SelectedItems.Count <= 0)
                return;

            ListViewItem lvi = lstViewPayEntriesHome.SelectedItems[0];
            PayEntry entry = _accountBook.GetPayEntry(lvi.Index);
            if (entry == null)
                return;

            SetInputData(entry);
            lvi.BackColor = Color.Yellow;
            _payEntryAddMode = false;
            btnAddOrEditPayEntry.Text = "Edit";
            _currEditPayEntry = entry;
            _currEditPayEntryView = lvi;
            ctxMenuPayEntriesList.Hide();
        }
        private void lstViewPayEntriesHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeletePayEntryFromList();  
        }

        private void ctxMenuPayEntriesList_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ctxMenuPayEntriesList_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == subMenuDeletePayEntry)
            {
                DeletePayEntryFromList();
            }
            else if (e.ClickedItem == subMenuEditPayEntry)
            {
                EditPayEntryAtList();
            }
        }

        private void lstViewMembers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int selCnt = 0;
            foreach (ListViewItem lvi in lstViewMembers.Items)
            {
                if (lvi.Checked)
                    selCnt++;
            }
            lstViewMembers.Columns[0].Text = "Select Members: (" + selCnt + ")";
        }
    }
}
