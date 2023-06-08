namespace ChallengeApp.DataModels
{
    public class Statistics
    {
        public float Min { get; set; }
        public float Max { get; set; }
        public float Average { get; set; }
        public char AverageLetter { get; set; }

        public void CalcStatisticsForGradesList(List<float> grades)
        {
            if (grades.Count > 0)
            {
                Max = float.MinValue;
                Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    Max = Math.Max(Max, grade);
                    Min = Math.Min(Min, grade);
                    Average += grade;
                }
                Average /= grades.Count;
            }
            switch (Average)
            {
                case > 80:
                    AverageLetter = 'A';
                    break;
                case > 60:
                    AverageLetter = 'B';
                    break;
                case > 40:
                    AverageLetter = 'C';
                    break;
                case > 20:
                    AverageLetter = 'D';
                    break;
                default:
                    AverageLetter = 'E';
                    break;
            }
        }
    }
}
