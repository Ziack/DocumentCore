using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Schema
{
    [Serializable]
    public class FileUploaded
    {
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long ContentLength { get; set; }
        public Stream InputStream { get; set; }
        public byte[] InputFile { get; set; }

        public override string ToString()
        {
            if (InputStream == null)
                return null;

            byte[] data = new byte[InputStream.Length];
            InputStream.Read(data, 0, (int)InputStream.Length);

            return Convert.ToBase64String(data);
        }
    }
}
