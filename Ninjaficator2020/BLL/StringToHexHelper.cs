using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjaficator2020.BLL
{
    public static class StringToIntHelper
    {
        /// <summary>
        /// Generate 3 ints using a source string converted to a hexadecimal number.
        /// Return empty array if source length is less the 2 or null.
        /// </summary>
        /// <param name="source">Source string</param>
        /// <returns>int array of length 3</returns>
        public static long[] GetIntsFromString(string source)
        {
            if (source == null || source.Length < 2)
                return new long[3];

            byte[] nameBytes = Encoding.Default.GetBytes(source);
            var hexedSource = BitConverter.ToString(nameBytes);
            hexedSource = hexedSource.Replace("-", "");

            long[] resultingInts = new long[3];
            

            int hexBlockLength = Convert.ToInt32(Math.Floor((decimal)hexedSource.Length/3));
            int hexFinalBlockLength = hexBlockLength + hexedSource.Length % 3;
            int hexBlockStar = 0;

            for (int i = 0; i < 3; i++)
            {
                int usableLength;

                if (i == 2)
                    usableLength = hexFinalBlockLength;
                else
                    usableLength = hexBlockLength;

                string subHex = hexedSource.Substring(hexBlockStar, usableLength);
                resultingInts[i] = long.Parse(subHex, System.Globalization.NumberStyles.HexNumber);
            }

            return resultingInts;
        }
    }
}
