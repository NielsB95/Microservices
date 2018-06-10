using System;
namespace Accounts.Data
{
    public class ContextFactory
    {
        public static AccountContext CreateContext()
        {
            return new AccountContext();
        }
    }
}
