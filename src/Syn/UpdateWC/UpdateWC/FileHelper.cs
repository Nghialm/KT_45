using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace UpdateWC
{
    public class FileHelper
    {
        public static List<FileVersion> ReadCsvFile(string file_name)
        {
            using (var reader = new StreamReader(file_name))
            {
                List<FileVersion> lstFileVer = new List<FileVersion>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    FileVersion objFile = new FileVersion();

                    objFile.Folder = values[0];
                    objFile.File = values[1];
                    objFile.Version = values[2];
                    objFile.FileName = objFile.Folder + (string.IsNullOrEmpty(objFile.Folder) ? @"\" : "") + objFile.File;

                    if (!String.IsNullOrEmpty(objFile.FileName))
                        lstFileVer.Add(objFile);
                }

                return lstFileVer;
            }
        }

        public static List<FileVersion> ListFileUpdate(List<FileVersion> clientLst, List<FileVersion> serverLst)
        {
            List<FileVersion> lstUpdate = new List<FileVersion>();
            foreach (FileVersion srv in serverLst)
            {
                bool flgAdd = true;
                foreach (FileVersion cli in clientLst)
                {
                    if (cli.FileName == srv.FileName)
                    {
                        if (cli.Version.CompareTo(srv.Version) < 0) flgAdd = true;
                        else flgAdd = false;
                        
                        break;
                    }
                }

                if (flgAdd) lstUpdate.Add(srv);
            }

            return lstUpdate;
        }
    }

    
}