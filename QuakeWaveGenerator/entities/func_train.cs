using QuakeWaveGenerator.utility;
using System;

namespace QuakeWaveGenerator.entities
{
#pragma warning disable IDE1006 // Naming Styles
    /// <summary>
    /// Represents a func_train Quake entity.
    /// </summary>
    public class func_train
#pragma warning restore IDE1006 // Naming Styles
    {
        private readonly bool m_MakeSound;
        private readonly string m_TextureName;
        private readonly string m_BaseTargetName;
        private readonly CubeVerticesCalculator m_CubeVerticesCalculator;
        private readonly string m_LeftFace;
        private readonly string m_RightFace;
        private readonly string m_FrontFace;
        private readonly string m_BackFace;
        private readonly string m_BottomFace;
        private readonly string m_TopFace;
        private readonly int m_Speed;

        /// <summary>
        /// Initialises a new instance of the <see cref="func_train"/> class with its properties set according to the passed arguments.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="length"></param>
        /// <param name="start_x"></param>
        /// <param name="start_y"></param>
        /// <param name="start_z"></param>
        /// <param name="spacing"></param>
        /// <param name="baseTargetName"></param>
        /// <param name="makeSound"></param>
        /// <param name="textureName"></param>
        /// <param name="speed"></param>
        public func_train(
            int row, int column, int length, 
            int start_x, int start_y, int start_z, 
            int spacing, string baseTargetName, bool makeSound, string textureName, int speed)
        {
            m_MakeSound = makeSound;
            m_TextureName = textureName;
            m_BaseTargetName = baseTargetName;
            m_Speed = speed;
            m_CubeVerticesCalculator = new CubeVerticesCalculator(row, column, length, spacing, start_x, start_y, start_z);
            m_LeftFace = GenerateFace(
                        m_CubeVerticesCalculator.LeftFrontTop_X, m_CubeVerticesCalculator.LeftFrontTop_Y, m_CubeVerticesCalculator.LeftFrontTop_Z,
                        m_CubeVerticesCalculator.LeftFrontBottom_X, m_CubeVerticesCalculator.LeftFrontBottom_Y, m_CubeVerticesCalculator.LeftFrontBottom_Z,
                        m_CubeVerticesCalculator.LeftBackTop_X, m_CubeVerticesCalculator.LeftBackTop_Y, m_CubeVerticesCalculator.LeftBackTop_Z,
                        m_TextureName);
            m_RightFace = GenerateFace(
                    m_CubeVerticesCalculator.RightBackTop_X, m_CubeVerticesCalculator.RightBackTop_Y, m_CubeVerticesCalculator.RightBackTop_Z,
                    m_CubeVerticesCalculator.RightBackBottom_X, m_CubeVerticesCalculator.RightBackBottom_Y, m_CubeVerticesCalculator.RightBackBottom_Z,
                    m_CubeVerticesCalculator.RightFrontTop_X, m_CubeVerticesCalculator.RightFrontTop_Y, m_CubeVerticesCalculator.RightFrontTop_Z,
                    m_TextureName);
            m_FrontFace = GenerateFace(
                    m_CubeVerticesCalculator.RightFrontTop_X, m_CubeVerticesCalculator.RightFrontTop_Y, m_CubeVerticesCalculator.RightFrontTop_Z,
                    m_CubeVerticesCalculator.RightFrontBottom_X, m_CubeVerticesCalculator.RightFrontBottom_Y, m_CubeVerticesCalculator.RightFrontBottom_Z,
                    m_CubeVerticesCalculator.LeftFrontTop_X, m_CubeVerticesCalculator.LeftFrontTop_Y, m_CubeVerticesCalculator.LeftFrontTop_Z,
                    m_TextureName);
            m_BackFace = GenerateFace(
                    m_CubeVerticesCalculator.LeftBackTop_X, m_CubeVerticesCalculator.LeftBackTop_Y, m_CubeVerticesCalculator.LeftBackTop_Z,
                    m_CubeVerticesCalculator.LeftBackBottom_X, m_CubeVerticesCalculator.LeftBackBottom_Y, m_CubeVerticesCalculator.LeftBackBottom_Z,
                    m_CubeVerticesCalculator.RightBackTop_X, m_CubeVerticesCalculator.RightBackTop_Y, m_CubeVerticesCalculator.RightBackTop_Z,
                    m_TextureName);
            m_BottomFace = GenerateFace(
                    m_CubeVerticesCalculator.LeftBackBottom_X, m_CubeVerticesCalculator.LeftBackBottom_Y, m_CubeVerticesCalculator.LeftBackBottom_Z,
                    m_CubeVerticesCalculator.LeftFrontBottom_X, m_CubeVerticesCalculator.LeftFrontBottom_Y, m_CubeVerticesCalculator.LeftFrontBottom_Z,
                    m_CubeVerticesCalculator.RightBackBottom_X, m_CubeVerticesCalculator.RightBackBottom_Y, m_CubeVerticesCalculator.RightBackBottom_Z,
                    m_TextureName);
            m_TopFace = GenerateFace(
                   m_CubeVerticesCalculator.RightFrontTop_X, m_CubeVerticesCalculator.RightFrontTop_Y, m_CubeVerticesCalculator.RightFrontTop_Z,
                   m_CubeVerticesCalculator.LeftFrontTop_X, m_CubeVerticesCalculator.LeftFrontTop_Y, m_CubeVerticesCalculator.LeftFrontTop_Z,
                   m_CubeVerticesCalculator.RightBackTop_X, m_CubeVerticesCalculator.RightBackTop_Y, m_CubeVerticesCalculator.RightBackTop_Z,
                    m_TextureName);
        }

        /// <summary>
        /// Returns the complete textual representation of the entity as needed for a map file.
        /// </summary>
        /// <returns>The string containing the entity.</returns>
        public override string ToString()
        {
            return string.Format(
                @"{{" + Environment.NewLine +
                @"  ""classname"" ""func_train""" + Environment.NewLine +
                @"  ""dmg"" ""0""" + Environment.NewLine +
                @"  ""speed"" """  + m_Speed + "" + Environment.NewLine +
                @"  ""sounds"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  {{" + Environment.NewLine, Convert.ToInt32(m_MakeSound), m_BaseTargetName + "_init") +
                 m_LeftFace +
                 m_RightFace +
                 m_FrontFace +
                 m_BackFace +
                 m_BottomFace +
                 m_TopFace +
                @"  }" + Environment.NewLine +
                @"}" + Environment.NewLine;
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
    }
}
