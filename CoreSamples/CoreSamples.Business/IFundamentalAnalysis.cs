using System.Collections.Generic;
using CoreSamples.Models;

namespace CoreSamples.Business
{
    public interface IFundamentalAnalysis
    {
        List<Ratio> GetRatios();
    }
}

