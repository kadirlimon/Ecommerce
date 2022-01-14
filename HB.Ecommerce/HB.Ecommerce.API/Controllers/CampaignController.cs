using HB.Ecommerce.Application.Contracts.Dto;
using HB.Ecommerce.Application.Contracts.Services;
using HB.Ecommerce.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampaignService _campaignService;
        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpGet]
        public async Task<BaseResponse<IList<Campaign>>> GetAll()
        {
            return await _campaignService.GetListAsync(); ;
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<Campaign>> Get(int id)
        {
            return await _campaignService.GetAsync(id);
        }

        [HttpPost("campaigninfo")]
        public async Task<BaseResponse<Campaign>> GetProductByProductCode([FromBody] string name)
        {
            return await _campaignService.GetCampaignByCampaignNameAsync(name);
        }

        [HttpPost]
        public async Task<BaseResponse<CampaignDto>> Create(CampaignDto _campaign)
        {
            var campaign = await _campaignService.CreateAsync(new Campaign(_campaign.Name, _campaign.ProductCode, _campaign.Duration, _campaign.PriceManipulationLimit, _campaign.TargetSalesCount));

            var campaignDto = new CampaignDto();
            campaignDto.ProductCode = campaign.Data.ProductCode;
            campaignDto.Name = campaign.Data.Name;
            campaignDto.Duration = campaign.Data.Duration;
            campaignDto.PriceManipulationLimit = campaign.Data.PriceManipulationLimit;
            campaignDto.TargetSalesCount = campaign.Data.TargetSalesCount;

            return new BaseResponse<CampaignDto>(campaignDto);
        }
    }
}
