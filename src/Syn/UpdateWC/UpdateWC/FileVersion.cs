using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UpdateWC
{
    [Serializable]
    public class FileVersion
    {
        public string Folder
        { get; set; }

        public string File
        { get; set; }

        public string FileName
        {
            get;set;
        }

        public string Version
        { get; set; }

        public FileVersion()
        { }

        public FileVersion(string folder, string file, string version)
        {
            Folder = folder;
            File = file;
            FileName = Folder + (string.IsNullOrEmpty(Folder) ? @"\" : "") + File;
            Version = version;
        }
    }
}