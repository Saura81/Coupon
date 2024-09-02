using Mango.Web.Models;
using Mango.Web.Models.Dto;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService :  BaseService, ICouponService
    {
        public CouponService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = couponDto,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = StaticDetails.CouponAPIBase + "/api/coupon" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = couponDto,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
        }
    }
}
