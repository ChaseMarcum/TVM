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

        public string[] equationName = { "Cash Flow from Assets",
                                         "Net Capital Spending",
                                         "Operating Cash Flow",
                                         "Quick Ratio",
                                         "Return on Equity One",
                                         "Return on Equity Two"
                                      };
        public int[] chapter = { 2,
                                 2,
                                 2,
                                 3,
                                 3,
                                 3};

        #region
        public string[] description = {"To calculate the Cash Flow from Assets you will need to take the total of the cash flow to creditors and the cash flow to stockholders, that is consisting of the operating cash flow, the capital spending, and the changes in net working capital.",
                                       "To calculate the Net Capital Spending you will need to take the Ending Net Fixed Asset and subtract it by the Beginning Net Fixed Assets and the Depreciation",
                                       "Operating Cash Flow is the cash generated from normal activity of the business.  To calculate take the Earnings Before Interest & Tax add the Depreciation and subtract the Taxes.",
                                       "The Quick Ratio is the measure of the short-term liquidity, after removing the effects of inventory.  To calculate you take the Current Assets subtracted by the Inventory and divide the result by the Current Liabilities.",
                                       "The Return on Equity or ROE is the ratio of the bottom-line profit per dollar of equity.  This is the first example of two possible ways to calculate the ROE. In this method to calculate the ROE take the Profit Margin and multiply it by the Total Asset Turnover and then multiply the result by the Equity Multiplier.",
                                       "The Return on Equity or ROE is the ratio of the bottom-line profit per dollar of equity.  This is the second example of two possible ways to calculate the ROE. In this method to calculate the ROE take the Net Income divided by the result of the Total Assets subtracted by the Total Debt."};
        #endregion
        #region
        public string[] firstVarName = {"Operating Cash Flow",
                                        "NFA(end)",
                                        "EBIT",
                                        "Current Assets",
                                        "Profit Margin",
                                        "Net Income"};

        public string[] secondVarName = {"Change in Net Working Capital",
                                         "NFA(beg)",
                                         "Depreciation",
                                         "Inventory",
                                         "Total Asset Turnover",
                                         "(Total Assets"};

        public string[] thirdVarName = {"Net Capital Spending",
                                        "Depreciation",
                                        "Taxes",
                                        "Current Liabilities",
                                        "Equity Mulitiplier",
                                        "Total Debt)"};
        #endregion
        #region
        public string[] firstEquationOperator = {"-",
                                                 "-",
                                                 "+",
                                                 "-",
                                                 "*",
                                                 "/"};

        public string[] secondEquationOperator = {"-",
                                                  "+",
                                                  "-",
                                                  "/",
                                                  "*",
                                                  "-"};
        #endregion
        public string[] resultType = {"Dollar",
                                      "Dollar",
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