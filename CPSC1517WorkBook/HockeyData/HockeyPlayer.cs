﻿using Utils;
namespace Hockey.Data
{
    public class HockeyPlayer
    {
        // data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;

 
        //properties
        public string BirthPlace
        {
            get

            {
                return _birthPlace;
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }
                //if we get here, then no exception happened
                _birthPlace = value;
            }

        }
        public string FirstName
        {
            get

            {
                return _firstName;
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                //if we get here, then no exception happened
                _firstName = value;
            }

        }
        public string LastName
        {
            get

            {
                return _lastName;
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }
                //if we get here, then no exception happened
                _lastName = value;
            }
        }
        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            private set
            {
                if (Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("Height must be positive.");
                }
                _heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }
            private set
            {
                if (!Utilities.IsPositive(value)) //== false
                {
                    throw new ArgumentException("Weight must be positive.");
                }
                _weightInPounds = value;
            }
        }
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            private set
            { 
                if (Utilities.IsInTheFuture(value))
                {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }
                _dateOfBirth = value;
            }
        }

        //Auto-implemented property
        public Position Position { get; set; }

        public Shot Shot { get; set; }

        //constructors
        
        /// <summary>
        /// Creates a default instance of a HockeyPlayer
        /// </summary>

       // public HockeyPlayer()
        // { 
         //   _firstName = string.Empty;
         //   _lastName = string.Empty;
          //  _birthPlace = string.Empty;
          //  _dateOfBirth = new DateOnly();
          //  _weightInPounds = 0;
          //  _heightInInches= 0;
          //  Shot = Shot.Left;
         //   Position = Position.Center;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthPlace"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="weightInPounds"></param>
        /// <param name="heightInInches"></param>
        /// <param name="position"></param>
        /// <param name="shot"></param>
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth, int weightInPounds, int heightInInches, Position position = Position.Center, Shot shot = Shot.Left)
        {
         BirthPlace = birthPlace;
            FirstName = firstName;
            LastName = lastName;
            HeightInInches = heightInInches;
            WeightInPounds= weightInPounds;
            DateOfBirth = dateOfBirth;
            Position = position;
            Shot = shot;
           
        }
        //Override of ToString
        public override string ToString()
        {
            return $"{FirstName}, {LastName}";
        }
    }
}