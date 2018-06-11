using System;
namespace Core.Util
{
    public static class Date
    {
        public static long Timestamp
        {
            get
            {
                return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
        }
    }
}
