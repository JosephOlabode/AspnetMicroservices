using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Discount.API.Entities;

namespace Discount.API.Repositories
{
    public interface IDiscountRepository
    {
        Task<IEnumerable<Coupon>> GetAllDiscount();
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
    } 
}
