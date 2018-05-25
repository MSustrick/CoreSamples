using System;
using System.Collections.Generic;
using System.Text;
using CoreSamples.Models;

namespace CoreSamples.Business
{

    public class FundamentalAnalysis : IFundamentalAnalysis
    {
        public List<Ratio> GetRatios()
        {
            var ratios = InitRatios();

            return ratios;
        }

        private List<Ratio> InitRatios()
        {
            var ratios = new List<Ratio>();

            ratios.Add(new Ratio()
            {
                Name = "Currency Ratio",
                Formula = "Current Assets/Current Liabilities",
                Description = "Divide current assets by current liabilities",
                Analysis = "Current assets should be 1.5 for long and < 1.0 for shorts"
            });

            ratios.Add(new Ratio()
            {
                Name = "Long Term Liability",
                Formula = "Long Term Debt/Equity",
                Description = "Divide long term debt by owners equity",
                Analysis = "The ratio should be < .30 %30"
            });

            return ratios;
        }
    }
}
