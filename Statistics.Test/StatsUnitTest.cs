using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{1.5F, 8.9F, 3.2F, 4.5F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
//         public void ReportsNaNForEmptyInput()
//         {
//             var statsComputer = new StatsComputer();
//             var computedStats = statsComputer.CalculateStatistics(
//                 new List<___>{});
//             //All fields of computedStats (average, max, min) must be
//             //Double.NaN (not-a-number), as described in
//             //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
//         }
    }
}
