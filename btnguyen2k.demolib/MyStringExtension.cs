using System.Security.Cryptography;
using System.Text;

namespace btnguyen2k.demolib;

public static class MyStringExtension
{
    /// <summary>
    /// Calculate MD5 hash of a string
    /// </summary>
    /// <param name="s">input string</param>
    /// <returns>MD5 hash of the input string</returns>
    public static string Md5Hash(this string s)
    {
        using (var md5 = MD5.Create())
        {
            var inputBytes = Encoding.UTF8.GetBytes(s);
            var hashBytes = md5.ComputeHash(inputBytes);
            var sb = new StringBuilder();
            foreach (var b in hashBytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
