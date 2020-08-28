namespace InjectionCoreProject
{
    // Required namespaces >>
    using System.Windows.Input;

    /// <summary>
    /// ViewModel for the <see cref="MainPage"/>
    /// </summary>
    public class MainPageViewModel : BaseViewModel
    {
        #region Public properties

        /*
         * All public properties for MainPageViewModel
         * should go here
         */

        #endregion

        #region Commands

        /*
         * All commands for MainPageVIewModel 
         * should go here
         */

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainPageViewModel()
        {
            // This stuff should be done only if the program is running
            if (ProgramState.IsRunning)
            {
                Init();
            }
        }

        #region Private methods

        /// <summary>
        /// Should be called in the constructor,
        /// Function will create all commands for the <see cref="MainPage"/>
        /// </summary>
        private void Init()
        {

        }

        #endregion
    }
}
