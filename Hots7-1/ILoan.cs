using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hots7_1
{
    public interface ILoan
    {


        string name { get; set; }
        string type { get; set; }
        double balance { get; set; }

        void Makepayment();
        void ApplyInterest();

    }
}
