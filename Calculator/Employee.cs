using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Employee
    {
        public string Name { get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                Regex regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                Match match = regex.Match(value);
                if(match.Success)
                {
                   _email=value;
                }
                else
                {
                    throw new Exception("Invalid email addresss");
                }
            }
        }
    }
}
