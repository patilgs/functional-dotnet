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
        public void Test_SubString18() {
            string[] ss = new string[2];
            ss[0] = "";
            ss[1] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString20() {
            string[] ss = new string[3];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString21() {
            string[] ss = new string[4];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            ss[3] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString04() {
            string[] ss = new string[3];
            ss[0] = "\u8000\0";
            ss[1] = "";
            ss[2] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString05() {
            string[] ss = new string[3];
            ss[0] = "\u8000";
            ss[1] = "";
            ss[2] = "";
            this.Test_SubString(ss, 1, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString06() {
            string[] ss = new string[3];
            ss[0] = "\u8000\u8000";
            ss[1] = "";
            ss[2] = "";
            this.Test_SubString(ss, 1, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString07() {
            string[] ss = new string[3];
            ss[0] = "\u8000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            ss[1] = "";
            ss[2] = "\u8000";
            this.Test_SubString(ss, 1, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString08() {
            string[] ss = new string[3];
            ss[0] = "\u8000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            ss[1] = "";
            ss[2] = "\u8000";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString09() {
            string[] ss = new string[3];
            ss[0] = "\u8000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            ss[1] = "";
            ss[2] = "\u8000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.Test_SubString(ss, 34, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString10() {
            string[] ss = new string[3];
            ss[0] = new string('\u2000', 25);
            ss[1] = "";
            ss[2] = "\u8000";
            this.Test_SubString(ss, 0, 26);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString11() {
            string[] ss = new string[3];
            ss[0] = "\u4000";
            ss[1] = "";
            ss[2] = new string('\u8000', 26);
            this.Test_SubString(ss, 0, 27);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString12() {
            string[] ss = new string[3];
            ss[0] = new string('\u4000', 28);
            ss[1] = "";
            ss[2] = new string('\u4000', 16);
            this.Test_SubString(ss, 0, 29);
        }

    }
}
