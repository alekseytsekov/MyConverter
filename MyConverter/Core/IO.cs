namespace MyConverter.Core
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using MyConverter.Globals;

    public static class IO
    {
        public static string GetDirectory(string path)
        {
            int lastCharOf = path.LastIndexOf(Default.DirectoryDelimiter, StringComparison.Ordinal);

            string directoryPath = path.Substring(0, lastCharOf);

            return directoryPath;
        }

        public static string GetFileName(string path)
        {
            int lastIndexOf = path.LastIndexOf(Default.DirectoryDelimiter, StringComparison.Ordinal);

            string fileName = path.Substring(++lastIndexOf);

            return fileName;
        }

        public static string ChangeExtension(string fileName, string extension)
        {
            int lastIndexOf = fileName.LastIndexOf(Default.ExtensionDelimiter);

            string nameWithOutExtension = fileName.Substring(0, lastIndexOf);

            fileName = nameWithOutExtension + extension;

            return fileName;
        }

        public static bool IsFileExists(string fileName)
        {
            var files = Directory.GetFiles(GetDirectory(fileName));

            return files.Contains(fileName);
        }

        public static string SetNewName(string fileName)
        {
            string directory = GetDirectory(fileName);
            string file = GetFileName(fileName);

            Regex regex = new Regex(Default.NumberOfRepeatsRegex);
            Match match = regex.Match(file);

            if (match.Success)
            {
                int digitFromFile = int.Parse(match.Groups[2].Value);

                digitFromFile++;

                string newDuplicateNum = digitFromFile.ToString();

                if (digitFromFile < 10)
                {
                    newDuplicateNum = "0" + digitFromFile;
                }

                file = match.Groups[1].Value + newDuplicateNum + match.Groups[3].Value;
            }
            else
            {
                var tokens = file.Split('.');

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (i == tokens.Length - 2)
                    {
                        sb.Append(tokens[i] + Default.DuplicateSuffix + Default.ExtensionDelimiter);
                    }
                    else if (i == tokens.Length - 1)
                    {
                        sb.Append(tokens[i]);
                    }
                    else
                    {
                        sb.Append(tokens[i] + Default.ExtensionDelimiter);
                    }
                }

                file = sb.ToString();
            }

            return Path.Combine(directory, file);
        }
    }
}
