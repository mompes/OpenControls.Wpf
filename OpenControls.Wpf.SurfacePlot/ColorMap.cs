using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenControls.Wpf.SurfacePlot
{
    class ColorMap
    {
        public static Color4 Parula(float value)
        {
            // Define la paleta de colores Parula
            int[,] palette = new int[,] {
            { 53, 42, 135 },
            { 15, 92, 221 },
            { 18, 125, 216 },
            { 7, 156, 207 },
            { 21, 177, 180 },
            { 89, 189, 140 },
            { 165, 190, 107 },
            { 225, 185, 82 },
            { 252, 206, 46 },
            { 249, 251, 14 }
        };

            // Calcular el índice del color
            float index = value * (palette.GetLength(0) - 1);
            int lowIndex = (int)Math.Floor(index);
            int highIndex = (int)Math.Ceiling(index);
            float highFrac = index - lowIndex;
            float lowFrac = 1.0f - highFrac;
            //int index = (int)Math.Round((double)value * (palette.GetLength(0) - 1));
            //index = Math.Min(Math.Max(index, 0), palette.GetLength(0) - 1);
            lowIndex = Math.Min(Math.Max(lowIndex, 0), palette.GetLength(0) - 1);
            highIndex = Math.Min(Math.Max(highIndex, 0), palette.GetLength(0) - 1);
            // Devuelve el color correspondiente
            return new Color4((palette[lowIndex, 0] * lowFrac + palette[highIndex, 0] * highFrac) / 255.0f,
                (palette[lowIndex, 1] * lowFrac + palette[highIndex, 1] * highFrac) / 255.0f,
                (palette[lowIndex, 2] * lowFrac + palette[highIndex, 2] * highFrac) / 255.0f,
                0.0f);
        }
    }
}
