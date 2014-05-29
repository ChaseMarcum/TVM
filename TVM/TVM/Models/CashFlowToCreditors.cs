using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TVM.Models
{
    public class CashFlowToCreditors: TwoVarEquation
    {

        public CashFlowToCreditors() :
        base(){}

        [Display(Name = "Interest Paid")]
        public  double firstVariable;

        [Display(Name = "Net New Borrowing")]
        public  double secondVariable;

        [Display(Name = "Cash Flow To Creditors")]
        public  double result;
        [Display(Name = "-")]

        public string myOperator = "-";
    }
}