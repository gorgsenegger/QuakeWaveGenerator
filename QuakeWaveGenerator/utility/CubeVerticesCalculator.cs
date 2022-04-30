namespace QuakeWaveGenerator.utility
{
    /// <summary>
    /// Calculator for the eight vertices of a cube with x, y and z coordinate each.
    /// </summary>
    public class CubeVerticesCalculator
    {
        /// <summary>
        /// The X coordinate for the left front bottom.
        /// </summary>
        public int LeftFrontBottom_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the left front bottom.
        /// </summary>
        public int LeftFrontBottom_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the left front bottom.
        /// </summary>
        public int LeftFrontBottom_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the right front bottom.
        /// </summary>
        public int RightFrontBottom_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the right front bottom.
        /// </summary>
        public int RightFrontBottom_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the right front bottom.
        /// </summary>
        public int RightFrontBottom_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the left back bottom.
        /// </summary>
        public int LeftBackBottom_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the left back bottom.
        /// </summary>
        public int LeftBackBottom_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the left back bottom.
        /// </summary>
        public int LeftBackBottom_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the right back bottom.
        /// </summary>
        public int RightBackBottom_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the right back bottom.
        /// </summary>
        public int RightBackBottom_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the right back bottom.
        /// </summary>
        public int RightBackBottom_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the left front top.
        /// </summary>
        public int LeftFrontTop_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the left front top.
        /// </summary>
        public int LeftFrontTop_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the left front top.
        /// </summary>
        public int LeftFrontTop_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the right front top.
        /// </summary>
        public int RightFrontTop_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the right front top.
        /// </summary>
        public int RightFrontTop_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the right front top.
        /// </summary>
        public int RightFrontTop_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the left back top.
        /// </summary>
        public int LeftBackTop_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the left back top.
        /// </summary>
        public int LeftBackTop_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the left back top.
        /// </summary>
        public int LeftBackTop_Z { get; private set; }

        /// <summary>
        /// The X coordinate for the right back top.
        /// </summary>
        public int RightBackTop_X { get; private set; }

        /// <summary>
        /// The Y coordinate for the right back top.
        /// </summary>
        public int RightBackTop_Y { get; private set; }

        /// <summary>
        /// The Z coordinate for the right back top.
        /// </summary>
        public int RightBackTop_Z { get; private set; }

        /// <summary>
        /// Initialises a new instance of the <see cref="CubeVerticesCalculator"/> based on the arguments, resulting in 
        /// the properties corresponding to the eight vertices of the resulting cube being filled accordingly.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="length"></param>
        /// <param name="spacing"></param>
        /// <param name="start_x"></param>
        /// <param name="start_y"></param>
        /// <param name="start_z"></param>
        public CubeVerticesCalculator(int row, int column, int length, int spacing, int start_x, int start_y, int start_z)
        {
            LeftFrontBottom_X = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            LeftFrontBottom_Y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            LeftFrontBottom_Z = start_z;

            RightFrontBottom_X = (column * length) + ((column - 1) * spacing) + start_x;
            RightFrontBottom_Y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            RightFrontBottom_Z = start_z;

            LeftBackBottom_X = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            LeftBackBottom_Y = (row * length) + ((row - 1) * spacing) + start_y;
            LeftBackBottom_Z = start_z;

            RightBackBottom_X = (column * length) + ((column - 1) * spacing) + start_x;
            RightBackBottom_Y = (row * length) + ((row - 1) * spacing) + start_y;
            RightBackBottom_Z = start_z;

            LeftFrontTop_X = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            LeftFrontTop_Y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            LeftFrontTop_Z = start_z + length;

            RightFrontTop_X = (column * length) + ((column - 1) * spacing) + start_x;
            RightFrontTop_Y = ((row - 1) * length) + ((row - 1) * spacing) + start_y;
            RightFrontTop_Z = start_z + length;

            LeftBackTop_X = ((column - 1) * length) + ((column - 1) * spacing) + start_x;
            LeftBackTop_Y = (row * length) + ((row - 1) * spacing) + start_y;
            LeftBackTop_Z = start_z + length;

            RightBackTop_X = (column * length) + ((column - 1) * spacing) + start_x;
            RightBackTop_Y = (row * length) + ((row - 1) * spacing) + start_y;
            RightBackTop_Z = start_z + length;
        }
    }
}
