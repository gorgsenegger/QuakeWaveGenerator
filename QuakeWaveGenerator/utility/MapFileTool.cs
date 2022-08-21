using QuakeWaveGenerator.entities;
using QuakeWaveGenerator.utility;
using System;
using System.Text;

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

        /// <summary>
        /// Put all parts required for a block that moves up and down between two <see cref="path_corner"/> entitites together.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="length"></param>
        /// <param name="start_x"></param>
        /// <param name="start_y"></param>
        /// <param name="start_z"></param>
        /// <param name="spacing"></param>
        /// <param name="makeSound"></param>
        /// <param name="textureName"></param>
        /// <param name="amplitude"></param>
        /// <param name="stepHeight"></param>
        /// <param name="speed"></param>
        /// <returns>The string for the map file.</returns>
        public string ConcatBlockParts(
            int row, int column, int length,
            int start_x, int start_y, int start_z,
            int spacing, bool makeSound, string textureName, int amplitude, int stepHeight, int speed)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string baseTargetName = GenerateBaseTargetName(row, column);

            func_train func_train =
                new func_train(row, column, length, start_x, start_y, start_z,
                    spacing, baseTargetName, makeSound, textureName, speed);
            stringBuilder.Append(func_train.ToString());

            CubeVerticesCalculator cubeVerticesCalculator =
                new CubeVerticesCalculator(row, column, length, spacing, start_x, start_y, start_z);

            // For the init path_corner entities, we use the amplitude plus the varying step height.
            path_corner path_corner = new path_corner(baseTargetName, PathCornerType.Init,
                cubeVerticesCalculator.LeftFrontBottom_X,
                cubeVerticesCalculator.LeftFrontBottom_Y,
                cubeVerticesCalculator.LeftFrontBottom_Z + amplitude + stepHeight);
            stringBuilder.Append(path_corner.ToString());

            // For the top path_corner entities, we use the amplitude as height.
            path_corner = new path_corner(baseTargetName, PathCornerType.Top,
                cubeVerticesCalculator.LeftFrontBottom_X,
                cubeVerticesCalculator.LeftFrontBottom_Y,
                cubeVerticesCalculator.LeftFrontBottom_Z + amplitude);
            stringBuilder.Append(path_corner.ToString());

            // The bottom path_corner entities we always leave the height as it is .
            path_corner = new path_corner(baseTargetName, PathCornerType.Bottom,
                cubeVerticesCalculator.LeftFrontBottom_X,
                cubeVerticesCalculator.LeftFrontBottom_Y,
                cubeVerticesCalculator.LeftFrontBottom_Z);
            stringBuilder.Append(path_corner.ToString());
            return stringBuilder.ToString();
        }
    }
}
