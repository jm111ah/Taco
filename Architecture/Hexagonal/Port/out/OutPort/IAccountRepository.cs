using Dto;
using Entity;

namespace OutPort
{
    public interface IAccountRepository
    {
        public  Task<SupplierAdminEntity> GetAccount(AccountDto requestDto);
    }
}