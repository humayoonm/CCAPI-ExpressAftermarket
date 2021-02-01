using CCAPI_ExpressAftermarket.Models.Contract;
using CCAPI_ExpressAftermarket.Models.Form;
using CCAPI_ExpressAftermarket.Models.Rating;
using Refit;
using System.Threading.Tasks;

namespace CCAPI_ExpressAftermarket.Interface
{
    [Headers("Authorization: Basic")]
    public interface IExpressAftermarketApi
    {
        [Post("/EX1PreRate/apijson")]
        Task<EX1PreRateOutput> GetEX1PreRate([Body] EX1PreRateModel model);

        [Post("/EX1Rate/apijson")]
        Task<EX1RateOutput> GetEX1Rate([Body] EX1RateModel model);

        [Post("/EX1Contract/apijson")]
        Task<EX1ContractOutput> GetEX1Contract([Body] EX1ContractModel model);

        [Post("/EX1ContractVoid/apijson")]
        Task<EX1ContractVoidOutput> GetEX1ContractVoid([Body] EX1ContractVoidModel model);

        [Post("/EX1Form/apijson")]
        Task<EX1FormOutput> GetEX1Form( [Body] EX1FormModel model);

    }
}
