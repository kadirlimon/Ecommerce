using HB.Ecommerce.Application;
using HB.Ecommerce.Application.Contracts.Services;
using HB.Ecommerce.Domain.Entity;
using HB.Ecommerce.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.Domain.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        public CampaignService(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }

        public async Task<BaseResponse<Campaign>> CreateAsync(Campaign entity)
        {
            try
            {
                var campaign= await _campaignRepository.CreateAsync(entity);
                return new BaseResponse<Campaign>(campaign);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Campaign>(ex.Message);
            }
        }

        public async Task<BaseResponse<int>> DeleteAsync(int id)
        {
            try
            {
                var campaign = await _campaignRepository.GetAsync(id);
                if (campaign != null)
                {
                    await _campaignRepository.DeleteAsync(id);
                    return new BaseResponse<int>(id);
                }
                else
                    return new BaseResponse<int>($"data is not found, id:{id}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<int>(ex.Message);
            }
        }

        public async Task<BaseResponse<Campaign>> GetAsync(int id)
        {
            try
            {
                var response = await _campaignRepository.GetAsync(id);
                return new BaseResponse<Campaign>(response);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Campaign>(ex.Message);
            }
        }

        public async Task<BaseResponse<Campaign>> GetCampaignByCampaignNameAsync(string name)
        {
            try
            {
                var campaign = await _campaignRepository.SingleOrDefaultAsync(x => x.Name == name);
                if (campaign != null)
                    return new BaseResponse<Campaign>(campaign);
                else
                    return new BaseResponse<Campaign>($"Not found campaign, campaign name={name}");
            }
            catch (Exception ex)
            {
                return new BaseResponse<Campaign>(ex.Message);
            }
        }

        public async Task<BaseResponse<IList<Campaign>>> GetListAsync()
        {
            try
            {
                var response = await _campaignRepository.GetListAsync();
                return new BaseResponse<IList<Campaign>>(response);
            }
            catch (Exception ex)
            {
                return new BaseResponse<IList<Campaign>>(ex.Message);
            }
        }

        public async Task<BaseResponse<Campaign>> UpdateAsync(Campaign entity)
        {
            try
            {
                var updateEntity = await _campaignRepository.UpdateAsync(entity);
                return new BaseResponse<Campaign>(updateEntity);
            }
            catch (Exception ex)
            {
                return new BaseResponse<Campaign>(ex.Message);
            }
        }
    }
}
