using DocumentManager.Core.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumentManager.Core.Attributes
{
    public class UploadFileAttributes : Attribute
    {
        public bool MultipleFile { get; set; }
        public string Maxfiles { get; set; }
        public string MaxFileSize { get; set; }

        public UploadFileAttributes(bool multipleFile, string maxfiles, string maxFileSize)
        {
            this.MultipleFile = multipleFile;
            this.Maxfiles = maxfiles;
            this.MaxFileSize = maxFileSize;
        }

        public static void Apply(Configuration configuration, ref List<Attribute> attributes)
        {
            if (configuration.MultipleFile.HasValue && !String.IsNullOrEmpty(configuration.MaxFiles) && !String.IsNullOrEmpty(configuration.MaxFilesize))                
            {
                attributes.Add(new UploadFileAttributes(multipleFile: configuration.MultipleFile.Value,
                                                       maxfiles: configuration.MaxFiles,
                                                       maxFileSize: configuration.MaxFilesize));                
                return;
            }

        }
    }
}