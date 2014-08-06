using System;

namespace eDrive.LightBlueBean
{
    /// <summary>
    /// Event Args for connection status changes from <see cref="IBean"/>
    /// </summary>
    public class BeanConnectionEventArgs
    {
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public BeanConnectionStatus Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeanConnectionEventArgs"/> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public BeanConnectionEventArgs(BeanConnectionStatus status)
        {
            Status = status;
        }
    }
}