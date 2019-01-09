using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace dbBackup.Managers
{
    public class BackupManager
    {

        public BackupManager()
        {

        }


        public string restoreFileName(string path,string fileName,string database)
        {
 
            string restoredName = "";


            restoredName = path + "_" + database + "_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".bak";



            return restoredName;
        }



        public void zipBackupFile(string sourceFile, string target,int bufferSize)
        {
            try
            {
                FileStream fsIn = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                FileStream fsOut = new FileStream(target, FileMode.Create, FileAccess.Write);
                ZipOutputStream zipOutputStream = new ZipOutputStream(fsOut);


                byte[] buffer = new byte[bufferSize];

                ZipEntry zipEntry = new ZipEntry(Path.GetFileName(sourceFile));
                zipOutputStream.PutNextEntry(zipEntry);

                int size;
                do
                {
                    size = fsIn.Read(buffer, 0, buffer.Length);
                    zipOutputStream.Write(buffer, 0, size);

                } while (size > 0);


                zipOutputStream.Close();
                fsIn.Close();
                fsOut.Close();
            }
            catch (Exception ex)
            {

                MessageManager.ShowErrorMessage(ex.Message);
            }

           

        }


    }
}
