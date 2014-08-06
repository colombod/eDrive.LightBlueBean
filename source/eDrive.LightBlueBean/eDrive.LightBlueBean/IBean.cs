using System;

namespace eDrive.LightBlueBean
{
    /// <summary>
    /// LightBlue Bean device inerface.
    /// </summary>
    public interface IBean : IDisposable
    {
        /// <summary>
        /// Gets the connection status.
        /// </summary>
        /// <value>
        /// The connection status.
        /// </value>
        BeanConnectionStatus ConnectionStatus { get; }

        /// <summary>
        /// Occurs when [connection status changed].
        /// </summary>
        event EventHandler<BeanConnectionEventArgs> ConnectionStatusChanged;
    }
}

