using System;
using Xunit;
using FileVersion;

namespace FileVersion.Tests {
    public class UnitTest1 {
        [Fact]
        public void GetVersionNumberFromPath() {
            var v = Parser
                .FromPath("src/FileVersion.1.0.1.zip")
                .Remove(".zip")
                .Remove("FileVersion.");

            Assert.Equal("1.0.1", v.Version);
        }

        [Fact]
        public void GetVersionNumberFromDirectory() {
            var v = Parser
                .FromDirectory("../../../../../tests", "Program*.txt")
                .Remove("Program.")
                .Remove(".txt");

            Assert.Equal("0.1.0", v.Version);
        }
    }
}
