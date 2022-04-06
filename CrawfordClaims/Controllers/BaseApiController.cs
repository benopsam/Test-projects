using Microsoft.AspNetCore.Mvc;

namespace CrawfordClaims
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {
            GetDatabase();
        }

        public ILossTypemanager LossTypeManager { get; set; }

        private void GetDatabase()
        {
            var factory = new LossTypeManagerFactory();
            LossTypeManager = factory.GetLossTypeManager();
        }
    }
}
