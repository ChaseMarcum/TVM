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
        public string description = "The description for the Time Value Money equation.";
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