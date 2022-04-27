using System;

namespace QuakeWaveGenerator
{
    /// <summary>
    /// Miscellaneous tooling methods for generating Quake Map File data.
    /// </summary>
    public class MapFileTool
    {
        /// <summary>
        /// Generates the base target name based on the passed row and column information.
        /// </summary>
        /// <param name="row">The row of the target path_corner.</param>
        /// <param name="column">The column of the target path_corner.</param>
        /// <returns>The base target name containing row and column information.</returns>
        public string GenerateBaseTargetName(int row, int column)
        {
            return "train_row-" + row.ToString("D3") + "_column-" + column.ToString("D3");
        }

        /// <summary>
        /// Generates a path_corner entity for various types (init, top, bottom) for the given coordinates.
        /// </summary>
        /// <param name="baseTargetName">The base target name to be used.</param>
        /// <param name="pathCornerType">The type of the path_corner (i.e. how it is used - for init, as top or as bottom).</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="z">The z coordinate.</param>
        /// <returns>The code lines for the path_corner entity.</returns>
        /// <exception cref="ArgumentException">Thrown when an invalid value for PathCornerType is passed.</exception>
        public string GeneratePathCorner(string baseTargetName, PathCornerType pathCornerType, int x, int y, int z)
        {
            string addTypeString;
            string addTargetNameString;
            switch (pathCornerType)
            {
                case PathCornerType.Init:
                    addTypeString = "_init";
                    addTargetNameString = "_bottom";
                    break;
                case PathCornerType.Bottom:
                    addTypeString = "_bottom";
                    addTargetNameString = "_top";
                    break;
                case PathCornerType.Top:
                    addTypeString = "_top";
                    addTargetNameString = "_bottom";
                    break;
                default:
                    throw new ArgumentException("Invalid value passed", "pathCornerType");
            }

            return string.Format(@"{{" + Environment.NewLine +
                @"  ""classname"" ""path_corner""" + Environment.NewLine +
                @"  ""targetname"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  ""origin"" ""{2} {3} {4}""" + Environment.NewLine +
                @"}}" + Environment.NewLine,
                baseTargetName + addTypeString, baseTargetName + addTargetNameString, x, y, z);
        }

        /// <summary>
        /// Generates the number of steps (in terms of height) that will be used for the wave 
        /// running through the func_path entities.
        /// </summary>
        /// <param name="numberOfSteps">The number of steps (i.e. how many different heights the func_train entities can have).</param>
        /// <param name="stepHeight">The height of each step.</param>
        /// <returns>An array containing the individual step heights going up from 0 and then going back down again (e.g. 0 2 4 6 8 6 4 2).</returns>
        public int[] StepSequence(int numberOfSteps, int stepHeight)
        {
            int[] steps = new int[numberOfSteps * 2];
            int index = 0;
            for (int i = 0; i < numberOfSteps; i++)
            {
                steps[index] = i * stepHeight;
                index++;
            }
            for (int i = numberOfSteps; i > 0; i--)
            {
                steps[index] = i * stepHeight;
                index++;
            }

            return steps;
        }
    }
}
