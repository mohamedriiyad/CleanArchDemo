using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using CleanArch.Application.Helper;

namespace CleanArch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost, DisableRequestSizeLimit]
        public IActionResult UploadFiles()
        {
            try
            {
                var files = Request.Form.Files.ToList();
                var folderName = Path.Combine("Resources", "Files");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (files.Any(f => f.Length == 0))
                {
                    return BadRequest();
                }

                FileHelper.UploadAll(files, pathToSave);
                return Ok("All Files Are Uploaded!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        
    }
}

