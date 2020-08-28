namespace InjectionCoreProject
{
    // Required namespaces >>
    using System;
    using System.Windows;

    /// <summary>
    /// A base attached propertie class that all other attached properties can inherit from
    /// </summary>
    /// <typeparam name="Parent">The property parent</typeparam>
    /// <typeparam name="Property">The property type</typeparam>
    public abstract class BaseAttachedPropertie<Parent, Property>
        where Parent: BaseAttachedPropertie<Parent, Property>,
                      new()
    {
        #region Public properties

        /// <summary>
        /// Create a new instance of the parent object
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Events

        /// <summary>
        /// Event for when the value of the attached property has changed
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        #endregion


        /// <summary>
        /// This is the dependency property
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached(
                "Value", typeof(Property), 
                typeof(BaseAttachedPropertie<Parent, Property>), 
                new PropertyMetadata(
                    new PropertyChangedCallback(OnPropertyChanged))
            );

        /// <summary>
        /// Is called when the property has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the virtual method
            Instance.OnValueChanged(d, e);
            // Call the event
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Override if extra stuff needs to be implemented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }


        #region Helper functions

        /// <summary>
        /// Gets the property
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Property GetProperty(DependencyObject d)
            =>
            // Get the value from the dependency property and return it
            (Property)d.GetValue(ValueProperty);

        /// <summary>
        /// Set the value of the attached property
        /// </summary>
        /// <param name="d"></param>
        /// <param name="value"></param>
        public static void SetValue(DependencyObject d, Property value)
            =>
            // Set the deoendency property value
            d.SetValue(ValueProperty, value);

        #endregion
    }
}
