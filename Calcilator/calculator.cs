using System;
using System.Collections.Generic;

namespace Calcilator
{
    public class calc {
        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            List<string> availablePeriods = new List<string>();

            TimeSpan currentTime = beginWorkingTime;
            TimeSpan endTime = endWorkingTime;

            for (int i = 0; i < startTimes.Length; i++)
            {
                TimeSpan busyStart = startTimes[i];
                TimeSpan busyEnd = startTimes[i] + TimeSpan.FromMinutes(durations[i]);

                if (busyStart > currentTime)
                {
                    TimeSpan freePeriodStart = currentTime;
                    TimeSpan freePeriodEnd = busyStart;

                    while (freePeriodStart + TimeSpan.FromMinutes(consultationTime) <= freePeriodEnd)
                    {
                        availablePeriods.Add($"{freePeriodStart:hh\\:mm}-{freePeriodStart.Add(TimeSpan.FromMinutes(consultationTime)):hh\\:mm}");
                        freePeriodStart = freePeriodStart.Add(TimeSpan.FromMinutes(consultationTime));
                    }

                    currentTime = busyEnd;
                }
                else
                {
                    currentTime = busyEnd;
                }
            }

            if (currentTime < endTime)
            {
                while (currentTime + TimeSpan.FromMinutes(consultationTime) <= endTime)
                {
                    availablePeriods.Add($"{currentTime:hh\\:mm}-{currentTime.Add(TimeSpan.FromMinutes(consultationTime)):hh\\:mm}");
                    currentTime = currentTime.Add(TimeSpan.FromMinutes(consultationTime));
                }
            }
            Console.WriteLine(availablePeriods.ToArray());
            return availablePeriods.ToArray();
        }

    }
}

