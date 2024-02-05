using Dto;

namespace InPort
{
    public interface IAccountService
    {
        public Task<bool> Login(AccountDto requestDto);
    }
}