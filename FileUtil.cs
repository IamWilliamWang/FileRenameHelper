using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重命名助手
{
    class FileUtil
    {
        public static void Rename(FileInfo file,string newName)
        {
            if (file.Name == newName)
                return;
            string command = "rename \"";
            command += file.FullName;
            command += "\" \"";
            command += newName;
            command += "\"";
            SystemCommandUtil.ExcuteCommand(command);
        }

        public static void Rename(string filename,string newName)
        {
            Rename(new FileInfo(filename), newName);
        }
    }
}
