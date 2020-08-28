namespace InjectionCoreProject
{
    /// <summary>
    /// This is the programs underlaying ViewModel
    /// </summary>
    public class ApplicationViewModel
    {
        /// <summary>
        /// Tells the view wich page to show
        /// </summary>
        public ApplicationPages CurrentPage { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ApplicationViewModel()
        {
            // Set the current page to the main page
            CurrentPage = ApplicationPages.MainPage;
        }
    }
}
