namespace ChallengeApp.DataModels
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Average => Count != 0 ? Sum / Count : 0;
        public char AverageLetter => Average switch
        {
            > 80 => 'A',
            > 60 => 'B',
            > 40 => 'C',
            > 20 => 'D',
            _ => 'E',
        };
        public int Count { get; private set; }

        public Statistics()
        {
            Min = 0;
            Max = 0;
            Sum = 0;
            Count = 0;
        }

        public void AddGrade(float grade)
        {
            Count++;
            if (Count == 1)
            {
                Min = grade;
                Max = grade;
            }
            else
            {
                Min = Math.Min(Min, grade);
                Max = Math.Max(Max, grade);
            }
            Sum += grade;
        }

        public static Statistics GetStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
