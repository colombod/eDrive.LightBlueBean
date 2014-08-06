using System;

namespace eDrive.LightBlueBean
{
    /// <summary>
    /// Event Args for connection status changes from <see cref="IBean"/>
    /// </summary>
    public class BeanConnectionEventHandler
    {
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public BeanConnectionStatus Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeanConnectionEventHandler"/> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public BeanConnectionEventHandler(BeanConnectionStatus status)
        {
            Status = status;
        }
    }
}