using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TVM.Models
{
    public class DividendsPerShare: TwoVarEquation
    {
        public DividendsPerShare() :
        base(){}

        [Display(Name = "Total Dividends")]
        public double firstVariable;

        [Display(Name = "Shares Outstanding")]
        public double secondVariable;

        [Display(Name = "Dividends Per Share")]
        public double result;
        [Display(Name = "/")]
        
        public string myOperator = "/";



    }
}