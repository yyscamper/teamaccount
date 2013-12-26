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

        #endregion

        public bool Validate()
        {
            return !(_payer == null || _members == null || _members.Length <= 0 || _money <= 0);
        }
    }
}
