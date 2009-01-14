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
        public void Test_Padding02() {
            this.Test_Padding("\0", 1551646209, '\u0001');
        }

        [Fact]
        public void Test_Padding04() {
            this.Test_Padding("", -268435456, '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Padding03() {
            this.Test_Padding("", 0, '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Padding13() {
            this.Test_Padding("", 1, '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Padding14() {
            this.Test_Padding("\0", 20, '\u0001');
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Padding15() {
            this.Test_Padding("", 26, '\u0001');
        }

    }
}
