using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        float average;
        float max;
        float min;
        
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            
            float sum = 0;
            float min = 0;
            float max = 0;
            foreach(float number in numbers){
                sum = sum + number;
                min = number < min ? number : min;
                max = number < max ? number : max;
            }
            average = sum / numbers.Count;
            
        }
    }
}
