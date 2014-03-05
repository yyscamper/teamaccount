using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount
{
    public class AccountBook
    {
        SortedDictionary<string, PayPerson> _allPerson;
        List<PayEntry> _allPayEntries;
        string[] _allPlaces;
        double _totalPaySum = 0.0;
        double[,] _p2pDebetTable = null;

        public double[,] P2PDebetTable
        {
            get { return _p2pDebetTable; }
        }

        public double TotalPaySum
        {
            get { return _totalPaySum; }
            set { _totalPaySum = value; }
        }

        public AccountBook()
        {
            _allPerson = new SortedDictionary<string, PayPerson>();

            string[] tmpNames = new string[] { "Felix", "Alfred", "Andy", "Leo", "Lyne", "Wayne", "Wenrey", "Phoebe", "Simon", "Tao", "Hunter" };
            for (int i = 0; i < tmpNames.Length; i++)
                _allPerson.Add(tmpNames[i], new PayPerson(tmpNames[i]));

            _allPayEntries = new List<PayEntry>();

            PayEntry e1 = new PayEntry();
            e1.Money = 100;
            e1.Payer = _allPerson["Alfred"];
            e1.Place = "耶里夏丽";
            e1.Time = new DateTime(2013, 12, 20, 12, 10, 0);
            e1.Comment = "不要忘记拿发票";
            e1.Members = new PayPerson[] { _allPerson["Alfred"], _allPerson["Andy"], _allPerson["Felix"], _allPerson["Hunter"] };

            PayEntry e2 = new PayEntry();
            e2.Money = 90;
            e2.Payer = _allPerson["Leo"];
            e2.Place = "兰州拉面";
            e2.Time = new DateTime(2013, 12, 22, 11, 45, 0);
            e2.Comment = "吃的还不错";
            e2.Members = new PayPerson[] { _allPerson["Tao"], _allPerson["Wayne"], _allPerson["Wenrey"] };

            PayEntry e3 = new PayEntry();
            e3.Money = 210;
            e3.Payer = _allPerson["Felix"];
            e3.Place = "西贝";
            e3.Time = new DateTime(2013, 12, 24, 12, 15, 0);
            e3.Comment = "菜少了点";
            e3.Members = new PayPerson[] { _allPerson["Felix"], _allPerson["Tao"], _allPerson["Alfred"], _allPerson["Simon"], _allPerson["Leo"], _allPerson["Andy"], _allPerson["Phoebe"] };

            AddPayEntry(e1);
            AddPayEntry(e2);
            AddPayEntry(e3);

            _allPlaces = new string[] { "耶里夏丽", "西贝", "兰州拉面", "稻谷鸡", "吉祥馄饨", "台味味" };
        }

        public SortedDictionary<string, PayPerson> AllPersons
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

        public PayEntry GetPayEntry(int index)
        {
            if (index < 0 || index >= _allPayEntries.Count)
                return null;

           return _allPayEntries[index];
        }

        public void AddPayEntry(PayEntry entry)
        {
            if (!entry.Validate())
                return;

            _allPayEntries.Add(entry);
            entry.Payer.PayCount++;
            entry.Payer.PaySum += entry.Money;
            entry.Payer.Expense += entry.Money;
            double avg = entry.Money / entry.Members.Length;

            foreach (PayPerson p in entry.Members)
            {
                p.AttendCount++;
                p.Expense -= avg;
            }
        }

        public void RemovePayEntry(int index)
        {
            if (index < 0 || index >= _allPayEntries.Count)
                return;

            PayEntry entry = _allPayEntries[index];
            entry.Payer.PayCount--;
            entry.Payer.PaySum -= entry.Money;
            entry.Payer.Expense += entry.Money;

            double avg = entry.Money / entry.Members.Length;
            foreach (PayPerson p in entry.Members)
            {
                p.AttendCount--;
                p.Expense += avg;
            }

            _allPayEntries.RemoveAt(index);
        }

        public void EditPayEntry(PayEntry preEntry, PayEntry newEntry)
        {
            newEntry.Payer.PayCount++;
            newEntry.Payer.PaySum += newEntry.Money;
            newEntry.Payer.Expense += newEntry.Money;
            double avg = newEntry.Money / newEntry.Members.Length;

            foreach (PayPerson p in newEntry.Members)
            {
                p.AttendCount++;
                p.Expense -= avg;
            }

            preEntry.Payer.PayCount--;
            preEntry.Payer.PaySum -= preEntry.Money;
            preEntry.Payer.Expense += preEntry.Money;

            avg = preEntry.Money / preEntry.Members.Length;
            foreach (PayPerson p in preEntry.Members)
            {
                p.AttendCount--;
                p.Expense += avg;
            }

            preEntry.Copy(newEntry);
        }

        private void RemovePayEntry(PayEntry entry)
        {
            //_allPayEntries.Remove(entry);
        }

        public void Calculate()
        {
            double[,] p2pDebet = new double[_allPerson.Count, _allPerson.Count];
            for (int i = 0; i < _allPerson.Count; i++)
                for (int j = 0; j < _allPerson.Count; j++)
                    p2pDebet[i, j] = 0.0;

            int idx = 0;
            foreach (PayPerson p in _allPerson.Values)
            {
                p.Reset();
                p.Index = idx++;
            }

            _totalPaySum = 0.0;
            foreach (PayEntry entry in _allPayEntries)
            {
                if (!entry.Validate())
                    continue;

                entry.Payer.Expense += entry.Money;
                entry.Payer.PayCount++;
                entry.Payer.PaySum += entry.Money;
                _totalPaySum += entry.Money;

                p2pDebet[entry.Payer.Index, entry.Payer.Index] += entry.Money;

                double avg = entry.Money / entry.Members.Length;
                foreach (PayPerson p in entry.Members)
                {
                    p.AttendCount++;
                    p.Expense -= avg;
                    if (p == entry.Payer)
                    {
                        p2pDebet[entry.Payer.Index, p.Index] -= avg ;
                    }
                    else
                    {
                        if (entry.Payer.Index > p.Index)
                        {
                            p2pDebet[entry.Payer.Index, p.Index] -= avg;
                        }
                        else
                        {
                            p2pDebet[entry.Payer.Index, p.Index] += avg;
                        }

                        p2pDebet[p.Index, entry.Payer.Index] = -p2pDebet[entry.Payer.Index, p.Index];
                    }
                }
            }

            _p2pDebetTable = p2pDebet;
        }

        private string GetUTF8String(string str)
        {
            byte[] encodeBytes = System.Text.Encoding.UTF8.GetBytes(str);
            string enStr = System.Text.Encoding.UTF8.GetString(encodeBytes);
            return enStr;
        }

        public void OpenFile(string filePath)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filePath, Encoding.GetEncoding("utf-8"));
            }
            catch (Exception err)
            {
                throw (err);
            }

            _allPayEntries.Clear();
            _allPerson.Clear();

            string line = null;
            line = reader.ReadLine(); //version
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line.Length < 3)
                    continue;

                if (line[0] == '/' && line[1] == '/')
                { //comment
                    continue;
                }

                string[] sArr = line.Split(new char[] { '|' });

                PayEntry entry = new PayEntry();
                if (sArr[0].Trim() == "A")
                {
                    entry.Type = PayType.Sum;
                }
                else
                {
                    entry.Type = PayType.Normal;
                }

                try
                {
                    entry.Time = DateTime.ParseExact(sArr[1], "yyyMMddhhmm", CultureInfo.InvariantCulture);
                }
                catch
                {
                    entry.Time = new DateTime(1900, 1, 1, 0, 0, 0);
                    entry.AddErrorFlag(PayEntryErrorFlag.TimeError);
                }

                try
                {
                    entry.Money = double.Parse(sArr[2]);
                }
                catch
                {
                    entry.AddErrorFlag(PayEntryErrorFlag.MoneyError);
                    entry.Money = 0;
                }

                entry.Place = sArr[3];// GetUTF8String(sArr[3]);

                string name = sArr[4];
                if (name.Contains(','))
                {
                    entry.Payer = null;
                    continue;
                }

                if (!_allPerson.ContainsKey(name))
                {
                    _allPerson.Add(name, new PayPerson(name));
                }
                entry.Payer = _allPerson[name];

                string[] attMems = sArr[5].Split(new char[] { ',' });
                ArrayList attList = new ArrayList();
                foreach (string m in attMems)
                {
                    if (!_allPerson.ContainsKey(m))
                        _allPerson.Add(m, new PayPerson(m));

                    attList.Add(_allPerson[m]);
                }

                PayPerson[] attPer = new PayPerson[attList.Count];
                attList.CopyTo(attPer);
                entry.Members = attPer;

                if (sArr.Length >= 7)
                    entry.Comment = sArr[6];

                _allPayEntries.Add(entry);
            }
        }
    }
}
