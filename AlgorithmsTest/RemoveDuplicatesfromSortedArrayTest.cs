using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedArrayTest
    {
        [Theory]
        [InlineData(new []{2,2,3}, 2)]
        [InlineData(new []{1,2,3,1,4,4,3}, 4)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution026.RemoveDuplicates(nums));
        }
    }
}

