using System;
using System.IO;
using System.Linq;

namespace FileVersion {
    public class Parser {
        public string FullName { private set; get; }
        public string Name { private set; get; }
        public string Version { private set; get; } = "";
        public static Parser FromPath(string fullName) {
            return new Parser {
                FullName = fullName,
                Name = Path.GetFileName(fullName),
                Version = Path.GetFileNameWithoutExtension(fullName)
            };
        }

        public static Parser FromDirectory(string dir, string filePattern) {
            var dirInfo = new DirectoryInfo(dir);
            var file = dirInfo
                .GetFiles(filePattern, SearchOption.AllDirectories)
                .OrderByDescending(x => x.Name)
                .First();
            return FromPath(file.FullName);
        }

        public Parser Remove(string part) {
            return new Parser {
                FullName = this.FullName,
                Name = this.Name,
                Version = this.Version.Replace(part, "")
            };
        }
    }
}