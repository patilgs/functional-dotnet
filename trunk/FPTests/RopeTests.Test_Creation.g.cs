// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Xunit;
using Microsoft.Pex.Framework.Generated;

namespace FPTests
{
    public partial class RopeTests {

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation01() {
            string[] ss = new string[0];
            this.Test_Creation(ss);
        }

        [Fact]
        public void Test_Creation04() {
            string[] ss = new string[2];
            ss[0] = new string('\0', 256);
            ss[1] = new string('\0', 256);
            this.Test_Creation(ss);
        }

        [Fact]
        public void Test_Creation06() {
            string[] ss = new string[2];
            ss[0] = new string('\0', 256);
            ss[1] = new string('\0', 256);
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation05() {
            string[] ss = new string[1];
            ss[0] = "";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation07() {
            string[] ss = new string[2];
            ss[0] = "";
            ss[1] = "";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation09() {
            string[] ss = new string[4];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            ss[3] = "";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation11() {
            string[] ss = new string[3];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation13() {
            string[] ss = new string[1];
            ss[0] = "\u4000";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation14() {
            string[] ss = new string[2];
            ss[0] = new string('\u2000', 25);
            ss[1] = "\u8000\u8000\u8000\u8000";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation15() {
            string[] ss = new string[2];
            ss[0] = "\u4000";
            ss[1] = new string('\u8000', 29);
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation16() {
            string[] ss = new string[2];
            ss[0] = "\u8000";
            ss[1] = "\u4000";
            this.Test_Creation(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Creation17() {
            string[] ss = new string[3];
            ss[0] = new string('\u8000', 25);
            ss[1] = new string('\u8000', 28);
            ss[2] = "\u8000\u8000\u8000\u8000\u8000\u8000\u8000\u8000";
            this.Test_Creation(ss);
        }

    }
}
