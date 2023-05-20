using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Toy
{
    public static class Colors
    {
        private static Color[] colors = { Color.Red, Color.Yellow, Color.Blue, Color.Green };
        private static Dictionary<Color, int> colorCosts = new Dictionary<Color, int>()
        {
            { Color.Red, 10 },
            { Color.Yellow, 5 },
            { Color.Blue, 0 },
            { Color.Green, -20 }
        };
        public static int GetColorCost(Color color)
        {
            if (colorCosts.ContainsKey(color))
                return colorCosts[color];
            else
                throw new ArgumentException("Invalid color");
        }
        public static Color GetRandomColor()
        {
            Random random = new Random();
            return colors[random.Next(colors.Length)];
        }
    }
}
