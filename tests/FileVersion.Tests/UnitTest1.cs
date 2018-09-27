using System;
using Xunit;
using FileVersion;

namespace FileVersion.Tests {
    public class UnitTest1 {
        [Fact]
        public void GetVersionNumber() {
            var v = Parser
                .From("src/FileVersion.1.0.1.zip")
                .Remove(".zip")
                .Remove("FileVersion.");

            Assert.Equal("1.0.1", v.Version);
        }
    }
}
