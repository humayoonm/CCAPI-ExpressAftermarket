using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CCAPI_ExpressAftermarket.Interface;
using CCAPI_ExpressAftermarket.Models;
using CCAPI_ExpressAftermarket.Models.Contract;
using CCAPI_ExpressAftermarket.Models.Form;
using CCAPI_ExpressAftermarket.Models.Rating;
using CCAPI_ExpressAftermarket.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Refit;
using Spark.Configuration;

namespace CCAPI_ExpressAftermarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpressAftermarketController : ControllerBase
    {
  
        
        private readonly ILogger<ExpressAftermarketController> _logger;
        private readonly IExpressAftermarketApi _webApi;
        private readonly AppConfig _configuration;
        private readonly TestData _repo;
        public ExpressAftermarketController(ILogger<ExpressAftermarketController> logger,IExpressAftermarketApi webApi ,
                                            IOptions<AppConfig> configuration, TestData repo)
        {          
            _logger = logger;
            _webApi = webApi;
            _configuration = configuration.Value;
            _repo = repo;
        }
        
 
        [HttpPost("GetEX1PreRate")]
        public async Task<EX1PreRateOutput> GetEX1PreRate(EX1PreRateModel data)
        {
            try
            {   
                return await _webApi.GetEX1PreRate(data);   
            }
            catch (Exception ex)
            {
                _logger.LogError("Error at EX1PreRate" + ex.Message);
                throw ex;
            }
        }

        [HttpPost("GetEx1Rate")]
        public async Task<EX1RateOutput> GetEX1Rate(EX1RateModel data)
        {
            try
            {
                return await _webApi.GetEX1Rate( data);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error at EX1Rate" + ex.Message);
                throw ex;
            }
        }
        
        [HttpPost("GetEx1Contract")]
        public async Task<EX1ContractOutput> GetEx1Contract(EX1ContractModel data)
        {
            try
            {
                return await _webApi.GetEX1Contract(data);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error at Ex1Contrcat" +ex.Message);
                throw ex;
            }
        }


        [HttpPost("GetEx1ContractVoid")]
        public async Task<EX1ContractVoidOutput> GetEx1ContractVoid(EX1ContractVoidModel data)
        {
            try
            {
                return  await _webApi.GetEX1ContractVoid( data);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error at EX1ContractVoid" + ex.Message);
                throw ex;
            }
        }


        [HttpPost("GetEx1Form")]
        public async Task<EX1FormOutput> GetEx1Form(EX1FormModel data)
        {
            try
            {
                return await _webApi.GetEX1Form(data);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error at EX1Form" + ex.Message);
                throw ex;
            }
        }









        # region Get Test Data in JSON Format

        [HttpGet("GetGapPreRateData")]
        public async Task<EX1PreRateModel> GetGapPreRateData()
        {
            try
            {
                return _repo.GetGapPreRateData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("GetVSCPreRateData")]
        public async Task<EX1PreRateModel> GetVSCPreRateData()
        {
                return _repo.GetVSCPreRateData();
        }
        [HttpGet("GetGAPRateData")]
        public async Task<EX1RateModel> GetGAPRateData()
        {
            return _repo.GetGapRateData();
        }
        [HttpGet("GetVSCRateData")]
        public async Task<EX1RateModel> GetVSCRateData()
        {
            return _repo.GetVSCRateData();
        }
        [HttpGet("GetEX1RateData")]
        public async Task<EX1RateModel> GetEX1RateData()
        {
            try
            {
                return _repo.GetGapRateData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetGapContractData")]
        public async Task<EX1ContractModel> GetGapContractData()
        {
            try
            {
                return _repo.GetGapContractData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetVSCContractData")]
        public async Task<EX1ContractModel> GetVSCContractData()
        {
            try {     return _repo.GetVSCContractData();     }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetEX1ContractVoidData")]
        public async Task<EX1ContractVoidModel> GetEX1ContractVoidData()
        {
            try
            {
                return  _repo.GetContractVoidData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetEX1FormData")]
        public async Task<EX1FormModel> GetEX1FormData()
        {
            try
            {
                return  _repo.GetFormData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
