using _3DPropertiesAPI.Dtos;
using _3DPropertiesAPI.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3DPropertiesAPI.Services
{
    public class MediaService
    {
        private readonly IWebHostEnvironment _environment;

        private readonly ExceptionsLoggerService _exceptionLogger;

        private readonly AppSettings _appSettings;

        public MediaService(IWebHostEnvironment environment, ExceptionsLoggerService exceptionLogger, IOptions<AppSettings> appSettings)
        {
            _environment = environment;
            _exceptionLogger = exceptionLogger;
            _appSettings = appSettings.Value;
        }

        // Upload file to his correspondant directory base on his category with a random name
        public async Task<string> UploadMedia(MediaDto objFile, string category)
        {
            string path = _environment.ContentRootPath + "\\Media\\" + category + "\\";

            // To save in Media path field
            var filePath = Path.Combine(path, Path.GetRandomFileName());

            try
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (FileStream fileStream = File.Create(filePath))
                {
                    await objFile.files.CopyToAsync(fileStream);
                    fileStream.Flush();
                    return filePath;
                }

            }
            catch (Exception ex)
            {
                _exceptionLogger.saveExceptionLog("Admin", "Upload " + category, ex.Message);

                throw ex;
            }
        }

        public bool DeleteMedia(string path, string category)
        {
            try
            {
                string filePath = _environment.ContentRootPath + "\\Media\\" + category + "\\";

                File.Delete(path);

                return true;

            }
            catch (Exception ex)
            {
                _exceptionLogger.saveExceptionLog("Admin", "Delete " + category, ex.Message);

                throw ex;
            }
        }

        public bool ValidateFileExtension(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            if (string.IsNullOrEmpty(extension) || !_appSettings.permittedExtensions.Contains(extension.ToLower()))
                return false;

            return true;
        }

        public bool ValidateFileSize(IFormFile file)
        {
            if (file.Length > _appSettings.FileSizeLimit || file.Length <= 0)
                return false;

            return true;
        }

        public bool ValidateFileName(IFormFile file)
        {
            string untrustedFileName = Path.GetFileName(file.FileName);

            Regex fileNameRegex = new Regex(_appSettings.FileNameRegex);

            if (untrustedFileName.Length > 256 || !fileNameRegex.Match(untrustedFileName).Success)
                return false;

            return true;
        }

        public string GetFileNameErrorMessage()
        {
            return $"file name must contain only alphanumeric characters ,underscores, dashs and 1 dot. Extension must contain only aphanumeric characters (Lower case)";
        }

        public string GetFileSizeErrorMessage()
        {
            return $"Maximum allowed file size is { _appSettings.FileSizeLimit} bytes.Minimum allowed file size is 0";
        }

        public string GetFileExtensionErrorMessage()
        {
            return $"This Media extension is not allowed!";
        }

        public string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".png", "image/png"},
                {".jpeg", "image/jpeg"},
                {".jpg", "image/jpeg"},
                {".gif", "image/gif"},
                {".pdf", "application/pdf"},
                {".mp4","video/mp4" },
                {".flv","video/x-flv" },
                {".3gp","video/3gpp" },
                {".mp3","audio/mpeg" },
                {".webm","video/webm" },
                {".mkv","video/x-matroska" },
                {".m4a","audio/mp4" },
                {".aac","audio/x-aac" },
                {".wma","audio/x-ms-wma" },
            };
        }
    }
}
