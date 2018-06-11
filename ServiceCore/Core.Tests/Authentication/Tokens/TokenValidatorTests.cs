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

        [TestMethod]
        public void ValidateExpiredTokenTest()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImpvaG4iLCJyb2xlIjoiQWRtaW4iLCJuYW1laWQiOiIxIiwibmJmIjoxNTI4NzM2NzY2LCJleHAiOjE1Mjg3Mzc5NjYsImlhdCI6MTUyODczNjc2Nn0.7GsgZH5zYEW6L4F-2QbWDIZBvNvGTVzGmdI7EhoRvQA";
            var result = TokenValidator.ValidateToken(token, out string username);
            Assert.IsFalse(result);
            Assert.AreEqual("john", username);
        }
    }
}
