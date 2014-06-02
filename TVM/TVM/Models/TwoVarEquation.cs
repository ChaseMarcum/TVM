﻿using System;
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

        public string[] equationName = {"Average Tax Rate",
                                        "Book Value of Assets",
                                        "Book Value Per Share",
                                        "Cash Flow from Assets",
                                        "Cash Flow to Creditors",
                                        "Cash Flow to Stockholders",
                                        "Change in Net Working Capital",
                                        "Current Ratio",
                                        "Days Sales in Inventory",
                                        "Days Sales in Recievables",
                                        "Dividends Per Share",
                                        "Earnings Per Share",
                                        "Inventory Turnover",
                                        "Market to Book Ratio",
                                        "Market Value of Assets",
                                        "Net Income Two Var",
                                        "Price to Sales Ratio",
                                        "Profit Margin",
                                        "Recievables Turnover",
                                        "Return on Assets",
                                        "Sales Per Share",
                                        "Total Debt Ratio"};
 

        public int[] chapter = { };

        #region
        public string[] description = {"Average Tax Rate Description",
                                        "Book Value of Assets Description",
                                        "Book Value Per Share Description",
                                        "Cash Flow from Assets Description",
                                        "Cash Flow to Creditors Description",
                                        "Cash Flow to Stockholders Description",
                                        "Change in Net Working Capital Description",
                                        "Current Ratio Description",
                                        "Days Sales in Inventory Description",
                                        "Days Sales in Recievables Description",
                                        "Dividends Per Share Description",
                                        "Earnings Per Share Description",
                                        "Inventory Turnover Description",
                                        "Market to Book Ratio Description",
                                        "Market Value of Assets Description",
                                        "Net Income Two Var Description",
                                        "Price to Sales Ratio Description",
                                        "Profit Margin Description",
                                        "Recievables Turnover Description",
                                        "Return on Assets Description",
                                        "Sales Per Share Description",
                                        "Total Debt Ratio Description"};
        #endregion
        #region
        public string[] firstVarName = {"Total Tax",
                                        "Book Value of Current Assets",
                                        "Total Equity",
                                        "Cash Flow to Creditors",
                                        "Interest Paid",
                                        "Dividends Paid",
                                        "Final Net Working Capital",
                                        "Current Assets",
                                        "Number of Days",
                                        "Number of Days",
                                        "Total Dividends",
                                        "Net Income",
                                        "Cost of Goods Sold",
                                        "Share Price",
                                        "Market Value of Current Assets",
                                        "Dividends",
                                        "Share Price",
                                        "Net Income",
                                        "Credit Sales",
                                        "Net Income",
                                        "Total Sales",
                                        "Total Debt"};
        
        public string[] secondVarName ={"Net Income",
                                        "Market Value of Fixed Assets",
                                        "Shares Outstanding",
                                        "Cash Flow to Stockholders",
                                        "Net New Borrowing",
                                        "Net New Equity",
                                        "Initial Net Working Capital",
                                        "Current Liabilities",
                                        "Inventory Turnover",
                                        "Recievables Turnover",
                                        "Shares Outstanding",
                                        "Shares Outstanding",
                                        "Inventory",
                                        "Book Value Per Share",
                                        "Market Value of Fixed Assets",
                                        "Addition to Retained Earnings",
                                        "Sales Per Share",
                                        "Sales",
                                        "Recievables",
                                        "Total Assets",
                                        "Shares Outstanding",
                                        "Total Assets"};
        #endregion
        #region
        public string[] equationOperator = {"/",
                                            "+",
                                            "/",
                                            "+",
                                            "-",
                                            "-",
                                            "-",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "+",
                                            "+",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/",
                                            "/"};
        #endregion
        public string[] resultType =   {"Percent",
                                        "Dollar",
                                        "Dollar",
                                        "Dollar",
                                        "Dollar",
                                        "Dollar",
                                        "Dollar",
                                        "Ratio",
                                        "Days",
                                        "Days",
                                        "Dollar",
                                        "Dollar",
                                        "Ratio",
                                        "Ratio",
                                        "Dollar",
                                        "Dollar",
                                        "Ratio",
                                        "Percent",
                                        "Ratio",
                                        "Percent",
                                        "Dollar",
                                        "Ratio"};
        public double firstVariable { get; set; }
        public double secondVariable{ get; set; }
        public double result { get; set; }
        //protected string myOperator { get; set; }
    }
}