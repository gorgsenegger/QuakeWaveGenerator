using System;

namespace QuakeWaveGenerator
{
    /// <summary>
    /// Miscellaneous tooling methods for generating Quake Map File data.
    /// </summary>
    public class MapFileTool
    {
        /// <summary>
        /// Generates the "func_train" entity code lines with properties set according to the UI selection.
        /// </summary>
        /// <param name="baseTargetName">The base name for the target the func_train is aiming to start from.</param>
        /// <param name="makeSound">Indicates whether a sound (ratchet metal) should be played.</param>
        /// <returns>The string representing the starting lines of a func_train entity.</returns>
        public string GenerateFuncTrainSettings(string baseTargetName, bool makeSound)
        {

            return string.Format(
                @"  ""classname"" ""func_train""" + Environment.NewLine +
                @"  ""dmg"" ""0""" + Environment.NewLine +
                @"  ""speed"" ""32""" + Environment.NewLine +
                @"  ""sounds"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  {{" + Environment.NewLine, Convert.ToInt32(makeSound), baseTargetName + "_init");
        }

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
            string addTypeString = string.Empty;
            string addTargetNameString = string.Empty;
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
        /// Generates a code line defining one of the six faces of a brush for the func_train entity.
        /// </summary>
        /// <param name="x1">The x coordinate for the first point of the plane defining the face.</param>
        /// <param name="y1">The y coordinate for the first point of the plane defining the face.</param>
        /// <param name="z1">The z coordinate for the first point of the plane defining the face.</param>
        /// <param name="x2">The x coordinate for the second point of the plane defining the face.</param>
        /// <param name="y2">The y coordinate for the second point of the plane defining the face.</param>
        /// <param name="z2">The z coordinate for the second point of the plane defining the face.</param>
        /// <param name="x3">The x coordinate for the third point of the plane defining the face.</param>
        /// <param name="y3">The y coordinate for the third point of the plane defining the face.</param>
        /// <param name="z3">The z coordinate for the third point of the plane defining the face.</param>
        /// <param name="textureName">The texture name to be used for.</param>
        /// <returns>The code line defining the face of the brush.</returns>
        public string GenerateFace(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3, string textureName)
        {
            string texture = textureName + " 0 0 0 1 1";
            return string.Format("    ({0:D4} {1:D4} {2:D4}) ({3:D4} {4:D4} {5:D4}) ({6:D4} {7:D4} {8:D4}) {9}",
                    x1, y1, z1, x2, y2, z2, x3, y3, z3, texture) + Environment.NewLine;
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
