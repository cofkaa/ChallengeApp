namespace ChallengeApp.DataModels
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Average { get; private set; }
        public char AverageLetter { get; private set; }
        public int Count { get; private set; }

        public Statistics()
        {
            Sum = 0;
            Count = 0;
            Average = 0;
        }

        public static Statistics GetStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Count = grades.Count;

            if (statistics.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Sum += grade;
                }
                statistics.Average = statistics.Sum / statistics.Count;
            }
            switch (statistics.Average)
            {
                case > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
