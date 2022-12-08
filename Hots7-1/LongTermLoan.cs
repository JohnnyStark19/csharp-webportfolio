using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hots7_1
{
    internal class LongTermLoan
    {
        private string _name;
        private string _type;
        private double _balance;

        const double LONG = 200;
        const double LONGINT = 0.05;

        public LongTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }

        }
        public string Type
        {
            get { return _type; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public double MakePayment()
        {
            return LONG;
        }

        public double ApplyInterest()
        {
            return LONGINT;
        }
    }
}
