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
        /// <summary>
        /// Current face up value of the die.
        /// </summary>
        public byte FaceValue { get; set; }

        /// <summary>
        /// True if the die is currently held.
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> 
        /// to the new number.
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            /// Generate random number
            Random randomRoll = new Random();
            byte newNumber = (byte)randomRoll.Next(1, 7);
            
            FaceValue = newNumber;
            
            return newNumber;
            
        }
    
    }
}
