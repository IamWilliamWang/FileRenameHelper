using System;
using System.IO;

namespace 重命名助手
{
    class FileUtil
    {
        private static string Join(String directory, String filename) => directory + '\\' + filename;

        public static string Rename(FileInfo file, string newName)
        {
            if (file.Name == newName)
                return newName;
            int postfix = 1;
            while (File.Exists(Join(file.DirectoryName, newName)))
            {
                postfix++;
                string rawFileName = newName.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries)[0];
                string extension = newName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[1];
                newName = rawFileName + " (" + postfix + ")." + extension;
            }
            string command = "rename \"";
            command += file.FullName;
            command += "\" \"";
            command += newName;
            command += "\"";
            SystemCommandUtil.ExcuteCommand(command);
            return newName;
        }

        public static void Rename(string filename, string newName)
        {
            Rename(new FileInfo(filename), newName);
        }
    }
}
