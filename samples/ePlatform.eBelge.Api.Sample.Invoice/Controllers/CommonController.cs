using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePlatform.Api.Core.QueryBuilder;
using ePlatform.eBelge.Api.Invoice.Models;
using ePlatform.eBelge.Api.Invoice.Outbox;
using ePlatform.eFatura.Models;
using ePlatform.eBelge.Api.Invoice.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using ePlatform.eBelge.Api.Sample.Invoice.Service;
using ePlatform.eBelge.Api.Models.Models;
using ePlatform.eBelge.Api.Models.Models.Enums;
using ePlatform.eBelge.Api.Invoice.EArchive;
using ePlatform.eBelge.Api.Invoice.Common;

namespace ePlatform.eBelge.Api.Sample.Invoice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly CommonClient commonClient;

        public CommonController(CommonClient commonClient)
        {
            this.commonClient = commonClient;
        }
        [HttpGet("isuser/{id}")] //id=0010047133
        public async Task<ActionResult<bool>> Get(string id)
        {
            return await commonClient.IsUser(id, 1);
        }
        [HttpGet("getuser/{id}")] //id=0010047133
        public async Task<ActionResult<GibUserWithAliasModel>> GetUser(string id)
        {
            return await commonClient.GetUser(id);
        }
        [HttpGet("aliaslist")]
        public async Task<ActionResult<PagedList<GibUserAliasModel>>> GetUserAliasList()
        {
            var model = new QueryFilterBuilder<GibUserAliasModel>()
                .PageIndex(1)
                .PageSize(50)
                .QueryFor(q => q.IsActive, Operator.Equal, true)
                .Build();
            return await commonClient.GetUserAliasList(model);
        }
        [HttpGet("currency")]
        public async Task<ActionResult<List<CurrencyModel>>> CurrencyCodeList()
        {
            return await commonClient.CurrencyCodeList();
        }
        [HttpGet("unit")]
        public async Task<ActionResult<List<UnitCodeModel>>> UnitCodeList()
        {
            return await commonClient.UnitCodeList();
        }
        [HttpGet("taxtypecode")]
        public async Task<ActionResult<List<TaxExemptionReasonModel>>> TaxExemptionReasonList()
        {
            return await commonClient.TaxExemptionReasonList();
        }
        [HttpGet("country")]
        public async Task<ActionResult<List<CountryModel>>> CountrList()
        {
            return await commonClient.CountrList();
        }
    }
}
