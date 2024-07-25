using System.Security.Cryptography;
using System.Text;

namespace MyPortfolio.Helper
{
    public class Common
    {
        public static string GetMd5Hash(MD5 md5Hash, string plainStr)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(plainStr)); // 평문(plainStr)을 Hash로 변경
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // x2 ----> 16진수 2자리로 builder에 집어 넣는다
            }

            return builder.ToString(); // 암호문 리턴
        }
    }
}
