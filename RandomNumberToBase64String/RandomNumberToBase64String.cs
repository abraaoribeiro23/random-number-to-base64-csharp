using System.Security.Cryptography;
using Xunit;

namespace RandomNumberToBase64String
{
    public class RandomNumberToBase64String
    {
        [Fact]
        public void RandomNumberToBase64StringTest()
        {
            using var provider = RandomNumberGenerator.Create();
            var bytes = new byte[32];
            provider.GetBytes(bytes);

            var resultToken = Convert.ToBase64String(bytes);
            Assert.NotEmpty(resultToken);
        }
    }
}