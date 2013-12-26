using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount
{
    public class AccountBook
    {
        Dictionary<string, PayPerson> _allPerson;
        List<PayEntry> _allPayEntries;
        string[] _allPlaces;

        public AccountBook()
        {
            _allPerson = new Dictionary<string, PayPerson>();

            string[] tmpNames = new string[] { "Felix", "Alfred", "Andy", "Leo", "Lyne", "Wayne", "Wenrey", "Phoebe", "Simon", "Tao", "Hunter" };
            for (int i = 0; i < tmpNames.Length; i++)
                _allPerson.Add(tmpNames[i], new PayPerson(tmpNames[i]));

            _allPayEntries = new List<PayEntry>();

            PayEntry e1 = new PayEntry();
            e1.Money = 100;
            e1.Payer = _allPerson["Felix"];
            e1.Place = "耶里夏丽";
            e1.Time = new DateTime(2013, 12, 20, 12, 10, 0);
            e1.Comment = "不要忘记拿发票";
            e1.Members = new PayPerson[] { _allPerson["Felix"], _allPerson["Andy"], _allPerson["Simon"] };

            PayEntry e2 = new PayEntry();
            e2.Money = 64.8;
            e2.Payer = _allPerson["Leo"];
            e2.Place = "兰州拉面";
            e2.Time = new DateTime(2013, 12, 22, 11, 45, 0);
            e2.Comment = "吃的还不错";
            e2.Members = new PayPerson[] { _allPerson["Tao"], _allPerson["Wayne"], _allPerson["Wenrey"], _allPerson["Felix"] };

            PayEntry e3 = new PayEntry();
            e3.Money = 180;
            e3.Payer = _allPerson["Felix"];
            e3.Place = "西贝";
            e3.Time = new DateTime(2013, 12, 24, 12, 15, 0);
            e3.Comment = "菜少了点";
            e3.Members = new PayPerson[] { _allPerson["Tao"], _allPerson["Alfred"], _allPerson["Simon"], _allPerson["Leo"], _allPerson["Andy"], _allPerson["Phoebe"] };

            AddPayEntry(e1);
            AddPayEntry(e2);
            AddPayEntry(e3);

            _allPlaces = new string[] { "耶里夏丽", "西贝", "兰州拉面", "稻谷鸡", "吉祥馄饨", "台味味" };
        }

        public Dictionary<string, PayPerson> AllPersons
        {
            get { return _allPerson; }
        }

        public List<PayEntry> AllPayEntries
        {
            get { return _allPayEntries; }
        }

        public string[] AllPlaces
        {
            get { return _allPlaces; }
        }

        public PayPerson GetPerson(string name)
        {
            if (_allPerson.ContainsKey(name))
                return _allPerson[name];
            else
                return null;
        }

        public void AddPayEntry(PayEntry entry)
        {
            if (!entry.Validate())
                return;

            _allPayEntries.Add(entry);
            entry.Payer.PayCount++;
            entry.Payer.Expense += entry.Money;
            double avg = entry.Money / entry.Members.Length;

            foreach (PayPerson p in entry.Members)
            {
                p.AttendCount++;
                p.Expense -= avg;
            }
        }

        public void Calculate()
        {
            foreach (PayEntry entry in _allPayEntries)
            {
                if (!entry.Validate())
                    continue;

                entry.Payer.Expense += entry.Money;
                entry.Payer.PayCount++;

                double avg = entry.Money / entry.Members.Length;
                foreach (PayPerson p in entry.Members)
                {
                    p.AttendCount++;
                    p.Expense -= avg;
                }
            }
        }
    }
}
