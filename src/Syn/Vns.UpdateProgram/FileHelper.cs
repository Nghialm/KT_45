using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Vns.UpdateProgram
{
    public class FileHelper
    {
        public static List<WSUpdate.FileVersion> ReadCsvFile(string filecsv)
        {
            using (var reader = new StreamReader(filecsv))
            {
                List<WSUpdate.FileVersion> lstFileVer = new List<WSUpdate.FileVersion>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    WSUpdate.FileVersion objFile = new WSUpdate.FileVersion();

                    objFile.Folder = values[0];
                    objFile.File = values[1];
                    objFile.Version = values[2];
                    objFile.FileName = objFile.Folder + (string.IsNullOrEmpty(objFile.Folder) ? @"\" : "") + objFile.File;

                    if (!String.IsNullOrEmpty(objFile.File))
                        lstFileVer.Add(objFile);
                }

                return lstFileVer;
            }
        }
    }

    public class Global
    {
        public static string Endpoint
        { get; set; }

        public static string Endpoint1
        { get; set; }

        public static string Endpoint2
        { get; set; }

        public static string Download
        { get; set; }

        public static string Download1
        { get; set; }

        public static string Download2
        { get; set; }
    }
}