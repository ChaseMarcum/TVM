using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TVM.Models
{
    public class ThreeVarEquation
    {
        public ThreeVarEquation()
        {

        }

        public string[] equationName = { "Net Capital Spending",
                                         "Operating Cash Flow",
                                         "Quick Ratio",
                                         "Return on Equity One",
                                         "Return on Equity Two"
                                      };
        public int[] chapter = { 2,
                                 2,
                                 3,
                                 3,
                                 3};

        #region
        public string[] description = {"This is the description for the Net Capital Spending Equation",
                                       "This is the description for the Operating Cash Flow Equation",
                                       "This is the description for the Quick Ratio Equation",
                                       "This is the description for the Return on Equity Equation",
                                       "This is the description for the Return on Equity Equation"};
        #endregion
        #region
        public string[] firstVarName = {"NFA(end)",
                                        "EBIT",
                                        "Current Assets",
                                        "Profit Margin",
                                        "Net Income"};

        public string[] secondVarName = {"NFA(beg)",
                                         "Depreciation",
                                         "Inventory",
                                         "Total Asset Turnover",
                                         "(Total Assets"};

        public string[] thirdVarName = {"Depreciation",
                                        "Taxes",
                                        "Current Liabilities",
                                        "Equity Mulitiplier",
                                        "Total Debt)"};
        #endregion
        #region
        public string[] firstEquationOperator = {"-",
                                                 "+",
                                                 "-",
                                                 "*",
                                                 "/"};

        public string[] secondEquationOperator = {"+",
                                                  "-",
                                                  "/",
                                                  "*",
                                                  "-"};
        #endregion
        public string[] resultType = {"Dollar",
                                      "Dollar",
                                      "Ratio",
                                      "Percent",
                                      "Percent"};
        public double firstVariable { get; set; }
        public double secondVariable { get; set; }

        public double thirdVariable { get; set; }
        public double result { get; set; }
        //protected string myOperator { get; set; }
    }
}