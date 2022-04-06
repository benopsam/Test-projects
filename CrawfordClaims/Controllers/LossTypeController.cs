using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrawfordClaims
{
    [ApiController]
    [Route("api/[controller]")]
    public class LossTypeController : BaseApiController
    {
        private readonly ILogger<LossTypeController> _logger;

        public LossTypeController(ILogger<LossTypeController> logger)
        {
            _logger = logger;
        }

        [HttpPost("getlosstypes")]
        public Response<LossType[]> GetLossTypes()
        {
            try
            {
                //Logic to get all Loss types
                var lossTypes = LossTypeManager.GetLossTypes();
                return new Response<LossType[]>() { ResponseData = lossTypes, HasError = false, ErrorText = null };
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString());
                return new Response<LossType[]>() { ResponseData = null, HasError = true, ErrorText = ex.ToString() };
            }
        }

        [HttpPost("getlosstype")]
        public Response<LossType> GetLossType(int id)
        {
            if (id <= 0)
            {
                _logger.Log(LogLevel.Information, "Invalid Id.");
                return new Response<LossType>() { ResponseData = null, HasError = true, ErrorText = "Invalid Id." };
            }

            try
            {
                //Logic to get Loss type based on id from DB
                var lossType = LossTypeManager.GetLossType(id);
                return new Response<LossType>() { ResponseData = lossType, HasError = false, ErrorText = null };

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString());
                return new Response<LossType>() { ResponseData = null, HasError = true, ErrorText = ex.ToString() };
            }
        }

        [HttpPost("addlostype")]
        public Response<int> AddLossType(LossType losstype)
        {
            if (losstype == null)
            {
                _logger.Log(LogLevel.Information, "Invalid loss type.");
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = "Invalid loss type." };
            }
            try
            {
                //Logic to add Loss type based on id from DB
                LossTypeManager.AddLossType(losstype);
                return new Response<int>() { ResponseData = 1, HasError = false, ErrorText = null };

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString());
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = ex.ToString() };
            }
        }

        [HttpPost("updatelosstype")]
        public Response<int> UpdateLossType(LossType losstype)
        {
            if (losstype == null)
            {
                _logger.Log(LogLevel.Information, "Invalid loss type.");
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = "Invalid loss type." };
            }
            try
            {
                //Logic to update Loss type based on id from DB
                LossTypeManager.UpdateLossType(losstype);
                return new Response<int>() { ResponseData = 1, HasError = false, ErrorText = null };

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString());
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = ex.ToString() };
            }
        }

        [HttpPost("deletelosstype")]
        public Response<int> DeleteLossType(int id)
        {
            if (id <= 0)
            {
                _logger.Log(LogLevel.Information, "Invalid id.");
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = "Invalid id." };
            }
            try
            {
                //Logic to delete Loss type based on id from DB
                LossTypeManager.DeleteLossType(id);
                return new Response<int>() { ResponseData = 1, HasError = false, ErrorText = null };

            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.ToString());
                return new Response<int>() { ResponseData = -1, HasError = true, ErrorText = ex.ToString() };
            }
        }
    }
}
