using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAccount
{
    public enum PayType : int
    {
        Normal = 0,
        Sum = 1
    }

    public enum PayEntryErrorFlag : int
    {
        NoError = 0x00,
        TimeError = 0x01,
        MoneyError = 0x02,
        PayerError = 0x04,
        AttendeeError = 0x08,
        TypeError = 0x10
    }

    public class PayEntry
    {
        #region class_members

        DateTime _time;
        double _money;
        string _place;
        string _comment;
        PayPerson _payer;
        PayPerson[] _members;
        PayType _type;
        int _errorFlag = 0;
        #endregion

        #region constructor

        public PayEntry()
        {
            _time = DateTime.Now;
            _money = 0.0;
            _place = string.Empty;
            _comment = string.Empty;
            _payer = null;
            _members = null;
            _type = PayType.Normal;
            _errorFlag = 0;
        }

        #endregion

        #region fields

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public PayPerson Payer
        {
            get { return _payer; }
            set { _payer = value; }
        }

        public PayPerson[] Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public PayType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int ErrorFlag
        {
            get { return ErrorFlag; }
            set { _errorFlag = value; }
        }

        public void AddErrorFlag(PayEntryErrorFlag flag)
        {
            _errorFlag |= (int)flag;
        }

        public void RemoveErrorFlag(PayEntryErrorFlag flag)
        {
            _errorFlag &= (~((int)flag));
        }

        #endregion

        public bool Validate()
        {
            return !(_payer == null || _members == null || _members.Length <= 0 || _money <= 0);
        }

        public void Copy(PayEntry entry)
        {
            _time = entry.Time;
            _money = entry.Money;
            _comment = entry.Comment;
            _payer = entry.Payer;
            _place = entry.Place;
            _type = entry.Type;
            _members = entry.Members;
        }
    }
}
