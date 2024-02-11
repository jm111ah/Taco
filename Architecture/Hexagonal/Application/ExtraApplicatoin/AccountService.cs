
using Dto;
using Encryption;
using Entity;
using InPort;
using OutPort;

namespace Applicatoin
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<bool> Login(AccountDto requestDto)
        {
            try
            {
                requestDto.Pw = SHA256.EncryptSHA256PassWord(requestDto.Pw!);

                SupplierAdminEntity resultEnitty = await _accountRepository.GetAccount(requestDto);

                if (resultEnitty == null)
                {
                    throw new Exception("등록된 회원이 없습니다.");
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}