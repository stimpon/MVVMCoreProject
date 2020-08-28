namespace InjectionCoreProject
{
    /// <summary>
    /// Interface for a Notification service class
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// All notification services should have an alert function
        /// </summary>
        public void Alert(string Message);
    }
}
