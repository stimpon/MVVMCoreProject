using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace InjectionCoreProject
{
    public class BasePage<T> : Page where T: BaseViewModel, new()
    {
        #region Public proprties

        /// <summary>
        /// The ViewModel for this page
        /// </summary>
        public T ViewModel
        {
            // Retirn the ViewModel
            get => viewModel;
            set
            {
                // Check if the ViewModel has changed
                if (viewModel == value) 
                    return;
                // Change the ViewModel if it has changed
                viewModel = value;
                // Update this page's datacontext
                this.DataContext = value;
            }
        }

        #endregion

        #region Private members

        /// <summary>
        /// Private instance of this page's ViewModel
        /// </summary>
        private T viewModel;

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            // Set the page's datacontext
            this.DataContext = new T();
        }
    }
}
