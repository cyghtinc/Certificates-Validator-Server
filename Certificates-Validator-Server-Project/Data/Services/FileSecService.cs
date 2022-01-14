using Certificates_Validator_Server_Project.Data.Models;
using Certificates_Validator_Server_Project.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certificates_Validator_Server_Project.Data.Services
{
    public class FileSecService
    {
        private AppDBContext _context;
        public FileSecService(AppDBContext context)
        {
            _context = context;
        }


        public void AddFileSec(FileSecVM filesecvm)
        {
            var _filesec = new FileSec()
            {
                fileAuthenticodeMD5 = filesecvm.fileAuthenticodeMD5,
                fileAuthenticodeSHA1 = filesecvm.fileAuthenticodeSHA1,
                fileAuthenticodeSHA256 = filesecvm.fileAuthenticodeSHA256,
                filename = filesecvm.filename,
                filepath = filesecvm.filepath,
                fileSignatureCatalog = filesecvm.fileSignatureCatalog,
                fileSignCompanyName = filesecvm.fileSignCompanyName,
                fileSigned = filesecvm.fileSigned,
                fileSignSerialNumber=filesecvm.fileSignSerialNumber,
                md5Hash=filesecvm.md5Hash,
                sha1Hash = filesecvm.sha1Hash,
                sha256Hash = filesecvm.sha256Hash
            };
            _context.Add(_filesec);
            _context.SaveChanges();

        }


        public FileSec GetFileSecBySHA256(string sha256) => _context.Files.FirstOrDefault(n => n.sha256Hash == sha256);

        public List<FileSec> GetAllFileSec() => _context.Files.ToList();
    }
}
