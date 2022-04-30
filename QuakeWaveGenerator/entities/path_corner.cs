using QuakeWaveGenerator.utility;
using System;

namespace QuakeWaveGenerator.entities
{
#pragma warning disable IDE1006 // Naming Styles
    /// <summary>
    /// Represents a path_corner Quake entity.
    /// </summary>
    public class path_corner
#pragma warning restore IDE1006 // Naming Styles
    {
        private readonly string m_BaseTargetName;
        private readonly PathCornerType m_PathCornerType;
        private readonly int m_X;
        private readonly int m_Y;
        private readonly int m_Z;

        /// <summary>
        /// Initialises a new instance of the <see cref="path_corner"/> class with its properties set according to the passed arguments.
        /// </summary>
        /// <param name="baseTargetName"></param>
        /// <param name="pathCornerType"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public path_corner(string baseTargetName, PathCornerType pathCornerType, int x, int y, int z)
        {
            m_BaseTargetName = baseTargetName;
            m_PathCornerType = pathCornerType;
            m_X = x;
            m_Y = y;
            m_Z = z;
        }

        /// <summary>
        /// Returns the complete textual representation of the entity as needed for a map file.
        /// </summary>
        /// <returns>The string containing the entity.</returns>
        public override string ToString()
        {
            string addTargetNameString = m_PathCornerType == PathCornerType.Bottom ? "_top" : "_bottom";
            return string.Format(@"{{" + Environment.NewLine +
                @"  ""classname"" ""path_corner""" + Environment.NewLine +
                @"  ""targetname"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  ""origin"" ""{2} {3} {4}""" + Environment.NewLine +
                @"}}" + Environment.NewLine,
                m_BaseTargetName + m_PathCornerType.DisplayName(), m_BaseTargetName + addTargetNameString, m_X, m_Y, m_Z);
        }
    }
}
