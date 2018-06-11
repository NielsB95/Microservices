using System;
using Core.Authentication.Tokens;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Tests.Authentication.Tokens
{
    [TestClass]
    public class TokenValidatorTests
    {
        [TestMethod]
        public void ValidateValidTokenTest()
        {
            var token = TokenGenerator.GenerateToken("John Joe");
            Assert.IsTrue(TokenValidator.ValidateToken(token, out string username));
            Assert.AreEqual("John Joe", username);
        }
    }
}
