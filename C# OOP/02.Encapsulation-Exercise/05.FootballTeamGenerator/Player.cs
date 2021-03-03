using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private const int minStatValue = 0;
        private const int maxStatValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;
            private set
            {
                Valdator.ThrowIfStringIsNullOrWhiteSpace(value, "A name should not be empty.");

                name = value;
            }
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                Valdator.
                    ThrowIfNumberIsNotInRange(value,
                    minStatValue,
                    maxStatValue,
                    $"{nameof(Endurance)} should be between {minStatValue} and {maxStatValue}.");

                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                Valdator.
                    ThrowIfNumberIsNotInRange(value,
                    minStatValue,
                    maxStatValue,
                    $"{nameof(Sprint)} should be between {minStatValue} and {maxStatValue}.");

                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                Valdator.
                    ThrowIfNumberIsNotInRange(value,
                    minStatValue,
                    maxStatValue,
                    $"{nameof(Dribble)} should be between {minStatValue} and {maxStatValue}.");

                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                Valdator.
                    ThrowIfNumberIsNotInRange(value,
                    minStatValue,
                    maxStatValue,
                    $"{nameof(Passing)} should be between {minStatValue} and {maxStatValue}.");

                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                Valdator.
                    ThrowIfNumberIsNotInRange(value,
                    minStatValue,
                    maxStatValue,
                    $"{nameof(Shooting)} should be between {minStatValue} and {maxStatValue}.");

                shooting = value;
            }
        }

        public double SkillLevel =>
         Math.Round((Endurance + Sprint + Dribble + Passing + Shooting) / 5.0);
    }
}
