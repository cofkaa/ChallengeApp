namespace ChallengeApp.DataModels
{
    public class Statistics
    {
        public float Min { get; set; }
        public float Max { get; set; }
        public float Average { get; set; }
        public char AverageLetter { get; set; }

        public static Statistics GetStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            if (grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= grades.Count;
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
