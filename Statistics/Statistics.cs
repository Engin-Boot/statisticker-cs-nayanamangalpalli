using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Stats stats = new Stats();
            
            float sum = 0;
            float min = 0;
            float max = 0;
            foreach(float number in numbers){
                sum = sum + number;
                min = number < min ? number : min;
                max = number < max ? number : max;
            }
            stats.average = sum / numbers.Count;
            stats.min = min;
            stats.max = max;
        
            return stats;
        }
    }
    Class Stats {

        float average;
        float max;
        float min;
    }
    
}
