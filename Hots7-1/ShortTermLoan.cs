using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hots7_1
{
    internal class ShortTermLoan 
    {

        private string _name;
        private string _type;
        private double _balance;

        const double SHORT = 450;
        const double SHORTINT = 0.10;
       

        public ShortTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }
        public ShortTermLoan(string name, string type)
        {
            _name = name;
            _type = type;
            
        }
        public ShortTermLoan(string name)
        {
            _name = name;
            

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
            return SHORT;
           
        }

       public double  ApplyInterest()
        {
            return SHORTINT;
        }

        //public override string ToString()
        //{
        //   // double bal = Balance - SHORT;
        //   // return Name.ToString() + " " + Type.ToString() + " " + Balance.ToString() + " " + bal;
        //}

    }
}
