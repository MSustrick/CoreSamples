using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSamples.Business;
using CoreSamples.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

//Swagger endpoint - http://localhost:56342/swagger/
namespace CoreSamples.Controllers
{
    [Produces("application/json")]
    [Route("api/FundamentalAnalysis")]
    public class FundamentalAnalysisController : Controller
    {
        private readonly IFundamentalAnalysis _fundamentalAnalysis;

        public FundamentalAnalysisController(IFundamentalAnalysis fundamentalAnalysis)
        {
            _fundamentalAnalysis = fundamentalAnalysis;
        }
        // GET: api/FundamentalAnalysis
        [HttpGet]
        public ActionResult Ratios()
        {
            try
            {
                var ratios = _fundamentalAnalysis.GetRatios();
                Log.Information("Ratios {@ratios}", ratios); //at sign shows the list for serilog, don't use $
                return Ok(ratios);
               
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest("something bad happened");
            }
        }

        // GET: api/FundamentalAnalysis/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/FundamentalAnalysis
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/FundamentalAnalysis/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
