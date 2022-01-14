using Certificates_Validator_Server_Project.Data.Services;
using Certificates_Validator_Server_Project.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certificates_Validator_Server_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesSecController:ControllerBase
    {
        public FileSecService _fileSecService;

        public FilesSecController(FileSecService fileSecService)
        {
            _fileSecService = fileSecService;
        }


        [HttpGet("get-all-filesec")]
        public IActionResult GetAllFileSec()
        {
            var allFileSec = _fileSecService.GetAllFileSec();
            return Ok(allFileSec);
        }


        [HttpGet("get-filesec-by-sha256.{sha256}")]
        public IActionResult GetFileSecBySHA256(string sha256)
        {
            var filesecSpecific = _fileSecService.GetFileSecBySHA256(sha256);
            return Ok(filesecSpecific);
        }



        [HttpPost]
        public IActionResult FileSecInCore([FromBody]FileSecVM filesec)
        {

            return Ok();
        }
    }
}
