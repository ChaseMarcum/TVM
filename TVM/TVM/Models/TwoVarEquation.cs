using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TVM.Models
{
    public class TwoVarEquation
    {
        public TwoVarEquation()
        {
            
        }

        public string[] equationName = { "Cash Flow To Creditors", 
                                         "Dividends Per Share",
                                         "Net Income Two Var",
                                         "Book Value Per Share",
                                         "Market to Book Ratio",
                                         "Market Value of Assets",
                                         "Book Value of Assets",
                                         "Average Tax Rate",
                                         "Change in Net Working Capital",
                                         "Cash Flow to Stockholders",
                                         "Cash Flow from Assets",
                                         "Current Ratio",
                                         "Return on Assets",
                                         "Profit Margin",
                                         "Recievables Turnover",
                                         "Days Sales in Recievables",
                                         "Inventory Turnover",
                                         "Days Sales in Inventory",
                                         "Total Debt Ratio",
                                         "Earnings Per Share",
                                         "Sales Per Share",
                                         "Price to Sales Ratio"};


        public string[] description = {"This is the description for the Cash Flow to Creditors Equation",
                                       "This is the description for the Dividends Per Share Equation",
                                       "This is the description for the Net Income Two Var Equation",
                                       "This is the description for the Book Value Per Share Equation",
                                       "This is the description for the Market to Book Ratio Equation",
                                       "This is the description for the Market Value of Assets Equation",
                                       "This is the description for the Book Value of Assets Equation",
                                       "This is the description for the Average Tax Rate Equation",
                                       "This is the description for the Change in Net Working Capital Equation",
                                       "This is the description for the Cash Flow to Stockholders Equation",
                                       "This is the description for the Cash Flow from Assets Equation",
                                       "This is the description for the Current Ratio Equation",
                                       "This is the description for the Return on Assets Equation",
                                       "This is the description for the Profit Margin Equation",
                                       "This is the description for the Recievables Turnover Equation",
                                       "This is the description for the Days Sales in Recievables Equation",
                                       "This is the description for the Inventory Turnover Equation",
                                       "This is the description for the Days Sales in Inventory Equation",
                                       "This is the description for the Total Debt Ratio Equation",
                                       "This is the description for the Earnings Per Share Equation",
                                       "This is the description for the Sales Per Share Equation",
                                       "This is the description for the Price to Sales Ratio Equation"};

        public string[] firstVarName = {"Interest Paid",
                                        "Total Dividends",
                                        "Dividends",
                                        "Total Equity",
                                        "Share Price",
                                        "Market Value of Current Assets",
                                        "Book Value of Current Assets",
                                        "Total Tax",
                                        "Final Net Working Capital",
                                        "Dividends Paid",
                                        "Cash Flow to Creditors",
                                        "Current Assets",
                                        "Net Income",
                                        "Net Income",
                                        "Credit Sales",
                                        "Number of Days",
                                        "Cost of Goods Sold",
                                        "Number of Days",
                                        "Total Debt",
                                        "Net Income",
                                        "Total Sales",
                                        "Share Price"};

        public string[] secondVarName = {"Net New Borrowing",
                                         "Shares Outstanding",
                                         "Addition to Retained Earnings",
                                         "Shares Outstanding",
                                         "Book Value Per Share",
                                         "Market Value of Fixed Assets",
                                         "Market Value of Fixed Assets",
                                         "Net Income",
                                         "Initial Net Working Capital",
                                         "Net New Equity",
                                         "Cash Flow to Stockholders",
                                         "Current Liabilities",
                                         "Total Assets",
                                         "Sales",
                                         "Recievables",
                                         "Recievables Turnover",
                                         "Inventory",
                                         "Inventory Turnover",
                                         "Total Assets",
                                         "Shares Outstanding",
                                         "Shares Outstanding",
                                         "Sales Per Share"};
 
        public string[] equationOperator = {"-",
                                            "/",
                                            "+",
                                            "/",
                                            "/",
                                            "+",
                                            "+",
                                            "/",
                                            "-",
                                            "-",
                                            "+",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/"};
        public double firstVariable { get; set; }
        public double secondVariable{ get; set; }
        public double result { get; set; }
        //protected string myOperator { get; set; }
    }
}