using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Certificates_Validator_Server_Project.Data.Models
{
    public class FileSec
    {
        public string filename { get; set; }
        public string md5Hash { get; set; }
        public string sha1Hash { get; set; }
        [Key]
        public string sha256Hash { get; set; } // current primary key
        public string filepath { get; set; }
        public bool fileSigned { get; set; } // file is signed with cert?
        public bool fileSignatureCatalog { get; set; } // only signed files - cert in file or in catalog?

        public string fileSignSerialNumber { get; set; } // serial number of certificate
        public string fileSignCompanyName { get; set; }
        public string fileAuthenticodeSHA1 { get; set; }
        public string fileAuthenticodeSHA256 { get; set; } // secondary key.
        public string fileAuthenticodeMD5 { get; set; }
        public bool fileINCore { get; set; } // determine if file part of our secure core.
    }
}
