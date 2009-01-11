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
        public void Test_Concat01() {
            string[] ss = new string[0];
            this.Test_Concat(ss, ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat02() {
            string[] ss = new string[1];
            ss[0] = "";
            this.Test_Concat(ss, ss);
        }

        [Fact]
        public void Test_Concat05() {
            string[] ss = new string[2];
            string[] ss1 = new string[31];
            ss[0] = "\u1000";
            ss[1] = "\u1000";
            ss1[0] = new string('\u1000', 28);
            ss1[1] = new string('\u1000', 28);
            ss1[2] = "\u2000";
            ss1[3] = new string('\u1000', 28);
            ss1[4] = new string('\u1000', 28);
            ss1[5] = new string('\u1000', 28);
            ss1[6] = new string('\u1000', 28);
            ss1[7] = new string('\u1000', 28);
            ss1[8] = new string('\u1000', 28);
            ss1[9] = new string('\u1000', 28);
            ss1[10] = new string('\u1000', 28);
            ss1[11] = new string('\u1000', 28);
            ss1[12] = new string('\u1000', 28);
            ss1[13] = new string('\u1000', 28);
            ss1[14] = new string('\u1000', 28);
            ss1[15] = new string('\u1000', 28);
            ss1[16] = new string('\u1000', 28);
            ss1[17] = new string('\u1000', 28);
            ss1[18] = new string('\u1000', 28);
            ss1[19] = new string('\u1000', 28);
            ss1[20] = new string('\u1000', 28);
            ss1[21] = new string('\u1000', 28);
            ss1[22] = new string('\u1000', 28);
            ss1[23] = new string('\u1000', 28);
            ss1[24] = new string('\u1000', 28);
            ss1[25] = new string('\u1000', 28);
            ss1[26] = new string('\u1000', 28);
            ss1[27] = new string('\u1000', 28);
            ss1[28] = new string('\u1000', 28);
            ss1[29] = new string('\u1000', 28);
            ss1[30] = new string('\u1000', 28);
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat12() {
            string[] ss = new string[2];
            string[] ss1 = new string[31];
            ss[0] = "\u1000";
            ss[1] = "\u1000";
            ss1[0] = new string('\u1000', 28);
            ss1[1] = new string('\u1000', 28);
            ss1[2] = "\u2000";
            ss1[3] = new string('\u1000', 28);
            ss1[4] = new string('\u1000', 28);
            ss1[5] = new string('\u1000', 28);
            ss1[6] = new string('\u1000', 28);
            ss1[7] = new string('\u1000', 28);
            ss1[8] = new string('\u1000', 28);
            ss1[9] = new string('\u1000', 28);
            ss1[10] = new string('\u1000', 28);
            ss1[11] = new string('\u1000', 28);
            ss1[12] = new string('\u1000', 28);
            ss1[13] = new string('\u1000', 28);
            ss1[14] = new string('\u1000', 28);
            ss1[15] = new string('\u1000', 28);
            ss1[16] = new string('\u1000', 28);
            ss1[17] = new string('\u1000', 28);
            ss1[18] = new string('\u1000', 28);
            ss1[19] = new string('\u1000', 28);
            ss1[20] = new string('\u1000', 28);
            ss1[21] = new string('\u1000', 28);
            ss1[22] = new string('\u1000', 28);
            ss1[23] = new string('\u1000', 28);
            ss1[24] = new string('\u1000', 28);
            ss1[25] = new string('\u1000', 28);
            ss1[26] = new string('\u1000', 28);
            ss1[27] = new string('\u1000', 28);
            ss1[28] = new string('\u1000', 28);
            ss1[29] = new string('\u1000', 28);
            ss1[30] = new string('\u1000', 28);
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat30() {
            string[] ss = new string[4];
            string[] ss1 = new string[30];
            ss[0] = new string('\u2000', 12);
            ss[1] = new string('\u1000', 28);
            ss[2] = new string('\u1000', 28);
            ss[3] = "\u8000\u8000\u8000\u8000";
            ss1[0] = new string('\u0400', 26);
            ss1[1] = new string('\u0400', 28);
            ss1[2] = new string('\u2000', 28);
            ss1[3] = new string('\u2000', 26);
            ss1[4] = "    ";
            ss1[5] = new string('\u0400', 26);
            ss1[6] = new string('\u0400', 26);
            ss1[7] = new string('\u0400', 26);
            ss1[8] = new string('\u0400', 26);
            ss1[9] = new string('\u0400', 26);
            ss1[10] = new string('\u0400', 26);
            ss1[11] = new string('\u0400', 26);
            ss1[12] = new string('\u0400', 26);
            ss1[13] = new string('\u0400', 26);
            ss1[14] = new string('\u0400', 26);
            ss1[15] = new string('\u0400', 26);
            ss1[16] = new string('\u0400', 26);
            ss1[17] = new string('\u0400', 26);
            ss1[18] = new string('\u0400', 26);
            ss1[19] = new string('\u0400', 26);
            ss1[20] = new string('\u0400', 26);
            ss1[21] = new string('\u0400', 26);
            ss1[22] = new string('\u0400', 26);
            ss1[23] = new string('\u0400', 26);
            ss1[24] = new string('\u0400', 26);
            ss1[25] = new string('\u0400', 26);
            ss1[26] = new string('\u0400', 26);
            ss1[27] = new string('\u0400', 26);
            ss1[28] = new string('\u0400', 26);
            ss1[29] = new string('\u0400', 26);
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat17() {
            string[] ss = new string[4];
            string[] ss1 = new string[30];
            ss[0] = new string('\u2000', 12);
            ss[1] = new string('\u1000', 28);
            ss[2] = new string('\u1000', 28);
            ss[3] = "\u8000\u8000\u8000\u8000";
            ss1[0] = new string('\u0400', 26);
            ss1[1] = new string('\u0400', 28);
            ss1[2] = new string('\u2000', 28);
            ss1[3] = new string('\u2000', 26);
            ss1[4] = "    ";
            ss1[5] = new string('\u0400', 26);
            ss1[6] = new string('\u0400', 26);
            ss1[7] = new string('\u0400', 26);
            ss1[8] = new string('\u0400', 26);
            ss1[9] = new string('\u0400', 26);
            ss1[10] = new string('\u0400', 26);
            ss1[11] = new string('\u0400', 26);
            ss1[12] = new string('\u0400', 26);
            ss1[13] = new string('\u0400', 26);
            ss1[14] = new string('\u0400', 26);
            ss1[15] = new string('\u0400', 26);
            ss1[16] = new string('\u0400', 26);
            ss1[17] = new string('\u0400', 26);
            ss1[18] = new string('\u0400', 26);
            ss1[19] = new string('\u0400', 26);
            ss1[20] = new string('\u0400', 26);
            ss1[21] = new string('\u0400', 26);
            ss1[22] = new string('\u0400', 26);
            ss1[23] = new string('\u0400', 26);
            ss1[24] = new string('\u0400', 26);
            ss1[25] = new string('\u0400', 26);
            ss1[26] = new string('\u0400', 26);
            ss1[27] = new string('\u0400', 26);
            ss1[28] = new string('\u0400', 26);
            ss1[29] = new string('\u0400', 26);
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat06() {
            string[] ss = new string[1];
            string[] ss1 = new string[1];
            ss[0] = new string('\u8000', 28);
            ss1[0] = "\u4000";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        public void Test_Concat07() {
            string[] ss = new string[30];
            ss[0] = new string('\u8000', 16);
            ss[1] = new string('\u0800', 28);
            ss[2] = "\u0800\u0800\u0800\u0800\u0800\u0800\u0800\u0800";
            ss[3] = new string('\u4000', 26);
            ss[4] = new string('\u0400', 26);
            ss[5] = new string('\u0800', 28);
            ss[6] = new string('\u4000', 26);
            ss[7] = new string('\u0200', 16);
            ss[8] = new string('\u0100', 28);
            ss[9] = "\u0400\u0400\u0400\u0400\u0400\u0400\u0400\u0400";
            ss[10] = new string('\u0200', 30);
            ss[11] = new string('\u0800', 28);
            ss[12] = new string('\u0800', 28);
            ss[13] = new string('\u0800', 28);
            ss[14] = new string('\u0800', 28);
            ss[15] = new string('\u0800', 28);
            ss[16] = new string('\u0800', 28);
            ss[17] = new string('\u0800', 28);
            ss[18] = new string('\u0800', 28);
            ss[19] = new string('\u0800', 28);
            ss[20] = new string('\u0800', 28);
            ss[21] = new string('\u0800', 28);
            ss[22] = new string('\u0800', 28);
            ss[23] = new string('\u0800', 28);
            ss[24] = new string('\u0800', 28);
            ss[25] = new string('\u0800', 28);
            ss[26] = new string('\u0800', 28);
            ss[27] = new string('\u0800', 28);
            ss[28] = new string('\u0800', 28);
            ss[29] = new string('\u0800', 28);
            this.Test_Concat(ss, ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat08() {
            string[] ss = new string[1];
            ss[0] = "\u8000";
            this.Test_Concat(ss, ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat09() {
            string[] ss = new string[2];
            string[] ss1 = new string[2];
            ss[0] = "\u0800";
            ss[1] = "\u0800";
            ss1[0] = new string('\u0800', 28);
            ss1[1] = "\u2000";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat10() {
            string[] ss = new string[30];
            string[] ss1 = new string[30];
            ss[0] = "\u2000\u2000\u2000\u2000";
            ss[1] = new string('\u0400', 28);
            ss[2] = "";
            ss[3] = "";
            ss[4] = "";
            ss[5] = "";
            ss[6] = "";
            ss[7] = "";
            ss[8] = "";
            ss[9] = "";
            ss[10] = "";
            ss[11] = "";
            ss[12] = "";
            ss[13] = "";
            ss[14] = "";
            ss[15] = "";
            ss[16] = "";
            ss[17] = "";
            ss[18] = "";
            ss[19] = "";
            ss[20] = "";
            ss[21] = "";
            ss[22] = "";
            ss[23] = "";
            ss[24] = "";
            ss[25] = "";
            ss[26] = "";
            ss[27] = "";
            ss[28] = "";
            ss[29] = "";
            ss1[0] = " ";
            ss1[1] = new string('\u0800', 28);
            ss1[2] = "";
            ss1[3] = "";
            ss1[4] = "";
            ss1[5] = "";
            ss1[6] = "";
            ss1[7] = "";
            ss1[8] = "";
            ss1[9] = "";
            ss1[10] = "";
            ss1[11] = "";
            ss1[12] = "";
            ss1[13] = "";
            ss1[14] = "";
            ss1[15] = "";
            ss1[16] = "";
            ss1[17] = "";
            ss1[18] = "";
            ss1[19] = "";
            ss1[20] = "";
            ss1[21] = "";
            ss1[22] = "";
            ss1[23] = "";
            ss1[24] = "";
            ss1[25] = "";
            ss1[26] = "";
            ss1[27] = "";
            ss1[28] = "";
            ss1[29] = "";
            this.Test_Concat(ss, ss1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat11() {
            string[] ss = new string[2];
            string[] ss1 = new string[2];
            ss[0] = "\u1000\u1000";
            ss[1] = "\u4000";
            ss1[0] = "\u4000";
            ss1[1] = "\u8000\u8000";
            this.Test_Concat(ss, ss1);
        }

    }
}
