namespace QuakeWaveGenerator
{
    /// <summary>
    /// The type of the path_corner.
    /// </summary>
    public enum PathCornerType
    {
        /// <summary>
        /// Default value.
        /// </summary>
        None = 0,

        /// <summary>
        /// path_corner used for initialising the func_train.
        /// </summary>
        Init = 1,

        /// <summary>
        /// The bottom of the path the func_train moves along.
        /// </summary>
        Bottom = 2,

        /// <summary>
        /// The top of the path the func_train moves along.
        /// </summary>
        Top = 3
    }
}
