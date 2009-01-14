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
        public void Test_StartsWithOrdinal08() {
            this.Test_StartsWithOrdinal("", "");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_StartsWithOrdinal09() {
            this.Test_StartsWithOrdinal("\0", "\0");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_StartsWithOrdinal10() {
            this.Test_StartsWithOrdinal("\u0002", "\0");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_StartsWithOrdinal11() {
            this.Test_StartsWithOrdinal("", "\0");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_StartsWithOrdinal12() {
            this.Test_StartsWithOrdinal("PPP", "pp");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_StartsWithOrdinal13() {
            this.Test_StartsWithOrdinal("\0\0\0", "\0\0");
        }

    }
}
