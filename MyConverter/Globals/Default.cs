namespace MyConverter.Globals
{
    public static class Default
    {
        public static int SecondsPerMin = 60;
        public static string ErrorLogPath = @"D:\convertError.txt";
        public static string DirectoryDelimiter = @"\";
        public static string ExtensionDelimiter = ".";
        public static string NumberOfRepeatsRegex = @"^(.+-)(\d+)(\..+)$";
        public static string DuplicateSuffix = "-01";
    }
}
