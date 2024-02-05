using System.ComponentModel.DataAnnotations;

namespace Dto
{
    public class AccountDto
    {
        [StringLength(20, MinimumLength =5)]
        public string? Id { get; set; }
        [StringLength(20, MinimumLength =10)]
        public string? Pw { get; set; }
    }
}