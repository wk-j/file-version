using System;
using System.IO;

namespace FileVersion {
    public class Parser {
        public string FullName { private set; get; }
        public string Name { private set; get; }
        public string Version { private set; get; } = "";
        public static Parser From(string fullName) {
            return new Parser {
                FullName = fullName,
                Name = Path.GetFileName(fullName),
                Version = Path.GetFileNameWithoutExtension(fullName)
            };
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