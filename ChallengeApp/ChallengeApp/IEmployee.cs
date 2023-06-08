﻿namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        char Gender { get; }

        void AddGrade(char grade);
        void AddGrade(decimal grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(float grade);

        Statistics GetStatistics();
    }
}
