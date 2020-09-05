using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
           Stats stats = new Stats();
            if(numbers.Count == 0){
                
                stats.average = float.NaN;
                stats.min = float.NaN;
                stats.max = float.NaN;
                return stats;
            }
            else{
                float sum = numbers[0];
                float min = numbers[0];
                float max = numbers[0];
                for(int i = 1; i< numbers.Count; i++){
                    sum = sum + numbers[i];
                    min = numbers[i] < min ? numbers[i] : min;
                    max = numbers[i] > max ? numbers[i] : max;
                }
                stats.average = sum / numbers.Count;
                stats.min = min;
                stats.max = max;
                
            return stats;
            }
            
        }
    }
    public class Stats {

        public float average;
        public float max;
        public float min;
    }
    
}
