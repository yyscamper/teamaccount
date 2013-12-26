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

        public FormMain()
        {
            InitializeComponent();

            _accountBook = new AccountBook();
            lstViewMembers.MultiSelect = true;
            cmbBoxPlace.Items.AddRange(_accountBook.AllPlaces);
            RefreshAllPersonsName();
            lstViewHistory.FullRowSelect = true;
            lstViewMembers.FullRowSelect = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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

                PayPerson p = _accountBook.GetPerson(lstViewMembers.Items[i].SubItems["Name"].ToString());
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



        private void btnAdd_Click(object sender, EventArgs e)
        {
            PayEntry entry = GetInputEntry();
            if (entry == null)
                return;

            _accountBook.AddPayEntry(entry);
            AddOnePayEntryView(entry);
        }

        private void AddOnePayEntryView(PayEntry entry)
        {
            ListViewItem lvi = new ListViewItem();
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
            lstViewHistory.Items.Add(lvi);
        }

        private void RefreshPayEntryHistoryView()
        {
            lstViewHistory.Items.Clear();
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
                lvi.SubItems.Add(p.Expense.ToString("F1"));

                lstViewMembers.Items.Add(lvi);
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
    }
}
