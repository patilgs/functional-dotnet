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
        public void Test_SubString02() {
            string[] ss = new string[1];
            ss[0] = "\u8000";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString03() {
            string[] ss = new string[1];
            ss[0] = "\u8000\0\0";
            this.Test_SubString(ss, 1, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString15() {
            string[] ss = new string[2];
            ss[0] = "\u8000";
            ss[1] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString06() {
            string[] ss = new string[1];
            ss[0] = "\u8000\u8000\u8000";
            this.Test_SubString(ss, 1, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString08() {
            string[] ss = new string[6];
            ss[0] = new string('\0', 28);
            ss[1] = new string('\u8000', 28);
            ss[2] = "\0";
            ss[3] = new string('\0', 28);
            ss[4] = "\0\0\0\0";
            ss[5] = new string('\0', 28);
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString09() {
            string[] ss = new string[6];
            ss[0] = new string('\0', 27);
            ss[1] = new string('\u8000', 27);
            ss[2] = "\0";
            ss[3] = new string('\0', 26);
            ss[4] = "\0";
            ss[5] = new string('\0', 27);
            this.Test_SubString(ss, 64, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString10() {
            string[] ss = new string[6];
            ss[0] = "\0\0";
            ss[1] = "\0";
            ss[2] = "\0";
            ss[3] = "\u4000\u4000";
            ss[4] = "\0";
            ss[5] = "\0";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString18() {
            string[] ss = new string[6];
            ss[0] = "\0";
            ss[1] = "";
            ss[2] = "\u8000";
            ss[3] = "";
            ss[4] = "";
            ss[5] = "";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString20() {
            string[] ss = new string[6];
            ss[0] = new string('\0', 29);
            ss[1] = "\0\0\0";
            ss[2] = new string('\0', 26);
            ss[3] = "\0\0";
            ss[4] = new string('\0', 26);
            ss[5] = "\u8000\u8000";
            this.Test_SubString(ss, 0, 86);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString21() {
            string[] ss = new string[7];
            ss[0] = "";
            ss[1] = "";
            ss[2] = "";
            ss[3] = "";
            ss[4] = "";
            ss[5] = "";
            ss[6] = "\u8000\0\0\0";
            this.Test_SubString(ss, 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString37() {
            string[] ss = new string[6];
            ss[0] = new string('\0', 26);
            ss[1] = new string('\u8000', 16);
            ss[2] = new string('\0', 30);
            ss[3] = "\0\0\0\0";
            ss[4] = new string('\0', 26);
            ss[5] = "\0\0\0\0";
            this.Test_SubString(ss, 72, 31);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString38() {
            string[] ss = new string[2];
            ss[0] = new string('@', 26);
            ss[1] = new string('\0', 16);
            this.Test_SubString(ss, 1, 26);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString39() {
            string[] ss = new string[6];
            ss[0] = "\0\0";
            ss[1] = "\0";
            ss[2] = "\0";
            ss[3] = new string('\0', 28);
            ss[4] = "\0\0";
            ss[5] = "\u1000";
            this.Test_SubString(ss, 0, 0);
        }

    }
}
