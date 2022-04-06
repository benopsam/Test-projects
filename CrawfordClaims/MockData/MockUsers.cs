using System.Collections.Generic;
using CrawfordClaims.Models;

namespace CrawfordClaims.MockData
{
    public class MockUsers
    {
        public static Dictionary<int, User> UserList = new Dictionary<int, User>()
        {
            { 1, new User { UserId = 1, UserName = "bestg", Password = "Georgie", DisplayName = "Georgie Best", IsActive = false } },
            { 2, new User { UserId = 2, UserName = "gemmela", Password = "Archie", DisplayName = "Archie Gemmel", IsActive = true } },
            { 3, new User { UserId = 3, UserName = "gemmela", Password = "Archie", DisplayName = "Archie Gemmel", IsActive = true } }
        };
    }
}
