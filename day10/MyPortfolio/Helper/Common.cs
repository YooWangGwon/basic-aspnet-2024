using System.Security.Cryptography;
using System.Text;

namespace MyPortfolio.Helper
{
    public class Common
    {
        public static string GetMd5Hash(MD5 md5Hash, string plainStr)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(plainStr)); // 평문(암호화하고자 하는 대상)을 해시로 변경
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();  // 암호문 리턴
        }
    }
}
