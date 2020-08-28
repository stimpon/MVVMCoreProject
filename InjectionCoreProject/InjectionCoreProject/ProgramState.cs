namespace InjectionCoreProject
{
    // Required namespaces >>
    using System.Diagnostics;

    /// <summary>
    /// Class that keep track of the programs current state
    /// </summary>
    static class ProgramState
    {
        /// <summary>
        /// Boolean value that returns true if the program is running
        /// </summary>
        public static bool IsRunning
        {
            get;
            set;
        }
    }
}
