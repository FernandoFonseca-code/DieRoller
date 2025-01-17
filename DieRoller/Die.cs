using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die ( 1-6).
    /// </summary>
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }
        /// <summary>
        /// Creates the die and rolls it to start
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// Current face up value of the die.
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> 
        /// to the new number if the die is not currently held.
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            if (!IsHeld)
            {

                /// Generate random number
                byte newNumber = (byte)_random.Next(1, 7);

                FaceValue = newNumber;
            }
            return FaceValue;
            
        }
    
    }
}
