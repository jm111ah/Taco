using Dto;
using InPort;
using Microsoft.AspNetCore.Mvc;

namespace ExtraNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] AccountDto requestDto)
        {
            return await _accountService.Login(requestDto) ? Ok() : BadRequest();
        }
    }
}
