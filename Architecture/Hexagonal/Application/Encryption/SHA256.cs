using System.Text;
using XSystem.Security.Cryptography;

namespace Encryption
{
    public static class SHA256
    {
        public static string EncryptSHA256PassWord(string originPw)
        {
            SHA256Managed sha256Managed = new SHA256Managed();
            var arrByte = Encoding.UTF8.GetBytes(originPw);
            var computeHash = sha256Managed.ComputeHash(arrByte);
            return Convert.ToBase64String(computeHash);
        }
    }
}