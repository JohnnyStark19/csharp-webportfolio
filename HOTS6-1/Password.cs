using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTS6_1
{
    internal class Password
    {
        private readonly string _raw;
        private readonly string _hash;
        



        //constructor 

        public Password(string raw, string hash)
        {
            _raw = raw;
            _hash = hash;
           
        }

        //Getters

        public string GetRaw()
        {
            return _raw;
        }

        public string GetHash()
        {
            return _hash;
        }
        
    }
}
