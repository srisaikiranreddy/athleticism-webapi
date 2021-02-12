using Microsoft.AspNetCore.Mvc;
using AthleticismWebAPI.DBRepo;
using System.Text.Json;

namespace AthleticismWebAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDBConnectionRepo _IDBConnectionRepo;
        public DataController(IDBConnectionRepo dBConnectionRepo)
        {
            _IDBConnectionRepo = dBConnectionRepo;
        }

        [HttpGet(Name = nameof(GetDatabaseTime))]
        public ActionResult GetDatabaseTime(ApiVersion version)
        {
            return Ok("Working");
        }
    }
}
