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
        public void Test_SubString13() {
            string[] ss = new string[2];
            ss[0] = "\u4000";
            ss[1] = "\u4000";
            this.Test_SubString(ss, 0, 2);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString16() {
            string[] ss = new string[2];
            ss[0] = "\u8000";
            ss[1] = "";
            this.Test_SubString(ss, 0, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString17() {
            string[] ss = new string[2];
            ss[0] = "\u8000\u8000";
            ss[1] = "";
            this.Test_SubString(ss, 1, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString06() {
            string[] ss = new string[2];
            ss[0] = new string('\u8000', 25);
            ss[1] = "@@@@";
            this.Test_SubString(ss, 0, 29);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString08() {
            string[] ss = new string[2];
            ss[0] = new string('\u8000', 30);
            ss[1] = "\u2000\u2000\u2000\u2000\u2000\u2000\u2000\u2000";
            this.Test_SubString(ss, 2, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString09() {
            string[] ss = new string[2];
            ss[0] = new string('\u8000', 25);
            ss[1] = new string('@', 16);
            this.Test_SubString(ss, 32, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString10() {
            string[] ss = new string[2];
            ss[0] = "\u2000";
            ss[1] = new string('\u8000', 26);
            this.Test_SubString(ss, 0, 27);
        }

    }
}
