using Dapper;
using Dto;
using Entity;
using OutPort;
using Query;
using System.Data;

namespace OutAdapter
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IDbContext _dbContext;

        public AccountRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SupplierAdminEntity> GetAccount(AccountDto requestDto)
        {
            using IDbConnection db = _dbContext.GetConnection();

            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", requestDto.Id);
            param.Add("@Pw", requestDto.Pw);

            return await db.QueryFirstAsync<SupplierAdminEntity>(ExtraSP.usp_Extra_GetCustomer, param, commandType: CommandType.StoredProcedure);
        }
    }
}