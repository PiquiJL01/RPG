﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public static class RNG
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minValue, int maxValue)
        {
            if (minValue < maxValue)
            {
                byte[] randomNumber = new byte[1];

                _generator.GetBytes(randomNumber);

                double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

                double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

                int range = maxValue - minValue + 1;

                double randomValueInRange = Math.Floor(multiplier * range);

                return (int)(minValue + randomValueInRange);
            }
            else
            {
                if (minValue == maxValue)
                {
                    return minValue;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
