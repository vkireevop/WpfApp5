using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calcilator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcilator.Tests
{
    [TestClass()]
    public class calcTests
    {
        [TestMethod()]
        public void AvailablePeriods_ReturnsCorrectIntervals()
        {
            TimeSpan[] startTimes = new TimeSpan[] { TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("15:30"), TimeSpan.Parse("16:50") };
            int[] durations = new int[] { 60, 30, 10, 10, 40 };
            TimeSpan beginWorkingTime = TimeSpan.Parse("08:00");
            TimeSpan endWorkingTime = TimeSpan.Parse("18:00");
            int consultationTime = 0;
            string[] result = Calcilator.calc.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);
            string[] expected = new string[] { "08:00-08:30",
                                                "08:30-09:00",
                                                "09:00-09:30",
                                                "09:30-10:00",
                                                "11:30-12:00",
                                                "12:00-12:30",
                                                "12:30-13:00",
                                                "13:00-13:30",
                                                "13:30-14:00",
                                                "14:00-14:30" ,
                                                "14:30-15:00",
"15:40-16:10",
"16:10-16:40",
"17:30-18:00"
                                               };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);    
            }
       
        }
    }

}