using System;

namespace QuakeWaveGenerator
{
    public class MapFileTool
    {
        public string GenerateFuncTrainSettings(int row, int column, string baseTargetName, bool makeSound)
        {

            return string.Format(
                @"  ""classname"" ""func_train""" + Environment.NewLine +
                @"  ""dmg"" ""0""" + Environment.NewLine +
                @"  ""speed"" ""32""" + Environment.NewLine +
                @"  ""sounds"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  {{" + Environment.NewLine, Convert.ToInt32(makeSound), baseTargetName + "_init");
        }

        public string GenerateBaseTargetName(int row, int column)
        {
            return "train_row-" + row.ToString("D3") + "_column-" + column.ToString("D3");
        }

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
                    break;
            }

            return string.Format(@"{{" + Environment.NewLine +
                @"  ""classname"" ""path_corner""" + Environment.NewLine +
                @"  ""targetname"" ""{0}""" + Environment.NewLine +
                @"  ""target"" ""{1}""" + Environment.NewLine +
                @"  ""origin"" ""{2} {3} {4}""" + Environment.NewLine +
                @"}}" + Environment.NewLine,
                baseTargetName + addTypeString, baseTargetName + addTargetNameString, x, y, z);
        }

        public string GenerateFace(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3, string textureName)
        {
            string texture = textureName + " 0 0 0 1 1";
            return string.Format("    ({0} {1} {2}) ({3} {4} {5}) ({6} {7} {8}) {9}",
                    x1, y1, z1, x2, y2, z2, x3, y3, z3, texture) + Environment.NewLine;
        }
    }
}
