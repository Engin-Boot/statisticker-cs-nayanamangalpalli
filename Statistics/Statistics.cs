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
                stats.CalculateAverage(numbers);
                stats.CalculateMin(numbers);
                stats.CalculateMax(numbers);
                
                return stats;
            }
            
        }
    }
    public class Stats {

        public float average;
        public float max;
        public float min;
        
        public void CalculateAverage(List<float> numbers){
            
            float sum = numbers[0];
            for(int i = 1; i< numbers.Count; i++){
                
                sum = sum + numbers[i];
            }
            this.average = sum / numbers.Count;
        }    
         
        public void CalculateMin(List<float> numbers){
            
            float min = numbers[0];
            for(int i = 1; i< numbers.Count; i++){
                
                min = numbers[i] < min ? numbers[i] : min;
            }
            this.min = min;
        }
        
        public void CalculateMax(List<float> numbers){
            
            float max = numbers[0];
            for(int i = 1; i< numbers.Count; i++){
                
                max = numbers[i] > max ? numbers[i] : max;
            }
            this.max=max;
        }
    }
    
}
