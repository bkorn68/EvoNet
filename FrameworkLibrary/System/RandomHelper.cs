using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace FrameworkLibrary.System
{
    public class RandomHelper
    {
        #region Fields
        public static Random _Random = new Random();
        #endregion

        #region Methods
        public static int GetInteger(int maxvalue, bool notzero)
        {
            int value = 0;
            do
            {
                value = _Random.Next(maxvalue);
            } while (notzero && (value == 0));

            return value;

        }
        public static string GetString(int length)
        {
            if (length == 0) length = RandomHelper.GetInteger(10, true);
            string value = string.Empty;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            value = new String(stringChars);
            if (string.IsNullOrEmpty(value))
            {
                value = Guid.NewGuid().ToString();
            }
            return value;

        }
        public static double GetDouble()
        {
            double value = _Random.NextDouble();
            return value;

        }
        public static decimal GetDecimal()
        {
            decimal value = (decimal)_Random.NextDouble();
            return value;

        }
        public static Color GetColor()
        {
            Color value = Color.FromArgb((byte)_Random.Next(0, 256), (byte)_Random.Next(0, 256), (byte)_Random.Next(0, 256), (byte)_Random.Next(0, 256)); ;
            return value;

        }
        public static bool GetBool()
        {
            bool value = (_Random.Next(0, 1) == 1);
            return value;

        }
        #endregion
    }
}
