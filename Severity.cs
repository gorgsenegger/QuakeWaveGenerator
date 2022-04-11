namespace QuakeWaveGenerator
{
    /// <summary>
    /// The severity of a log message.
    /// </summary>
    public enum Severity
    {
        /// <summary>
        /// Default value.
        /// </summary>
        None = 0,

        /// <summary>
        /// Informational.
        /// </summary>
        Info = 1,

        /// <summary>
        /// Warning that still allows the program to run.
        /// </summary>
        Warning = 2,

        /// <summary>
        /// An error indicating that something didn't work.
        /// </summary>
        Error = 3
    }
}
