using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TVM.Models
{
    public class TimeValueMoney
    {
        public TimeValueMoney()
        { 
        
        }


        public string name = "Time Value Money";
        public string description = "Time Value Money is the financial theory that the value of money you have now is greater than a reliable promise to receive the same amount of money at a future date.  Time Value Money is based on interest and can be used to compare investments, such as loans, bonds, mortgages, leases and savings.";
        public string firstVariableName = "NPER";
        public string secondVariableName = "Rate";
        public string thirdVariableName = "Present Value";
        public string fourthVariableName = "Payment";
        public string fifthVariableName = "Future Value";
        public int chapter = 4;
        public double firstVariable { get; set; }
        public double secondVariable { get; set; }
        public double thirdVariable { get; set; }
        public double fourthVariable { get; set; }
        public double fifthVariable { get; set; }
    }
}