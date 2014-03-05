using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount
{
    public class PayPerson
    {
        string _name = string.Empty;
        double _expense = 0.0;
        long _attendCnt = 0;
        long _payCnt = 0;
        double _paySum = 0.0;

        int _index = 0;


        public PayPerson()
        {

        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public PayPerson(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Expense
        {
            get { return _expense; }
            set { _expense = value; }
        }

        public long AttendCount
        {
            get { return _attendCnt; }
            set { _attendCnt = value; }
        }

        public long PayCount
        {
            get { return _payCnt; }
            set { _payCnt = value; }
        }

        public double PaySum
        {
            get { return _paySum; }
            set { _paySum = value; }
        }

        public void Reset()
        {
            _attendCnt = 0;
            _expense = 0.0;
            _payCnt = 0;
            _paySum = 0.0;
        }
    }
}
