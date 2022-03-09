using System;
using System.Threading.Tasks;
using Dapper;
using Discount.API.Entities;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Discount.API.Repositories
{
    public class DiscountRepository: IDiscountRepository
    {
        private readonly IConfiguration _configuration;

        public DiscountRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        Task<bool> IDiscountRepository.CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDiscountRepository.DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        async Task<Coupon> IDiscountRepository.GetDiscount(string productName)
        {
            using var connection = new NpgsqlConnection(_configuration.GetValue<string>("DatabaseSettings:ConnectionString"));

            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>
                ("SELECT * FROM Coupon where ProductName = @ProductName", new { ProductName = productName });
            if(coupon == null)
            {
                return new Coupon { ProductName = "No Discount", Amount = 0, Description = "No Discount Desc" };
            }

            return coupon;
        }

        Task<bool> IDiscountRepository.UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
