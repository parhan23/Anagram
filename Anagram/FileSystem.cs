using System.IO;

namespace Anagram
{
    static class FileSystem
    {
        static public string LoadText(string src)
        {
            string text;

            using (StreamReader file =
                new StreamReader(src))
            {
                text = file.ReadToEnd();
            }

            return text;
        }

        static public void SaveText(string dest, string src)
        {
            using (StreamWriter file =
                new StreamWriter(dest))
            {
                file.Write(src);
            }
        }
    }
}