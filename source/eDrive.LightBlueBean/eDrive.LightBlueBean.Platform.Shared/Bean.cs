using System;

namespace  eDrive.LightBlueBean.Platform
{
    /// <summary>
    /// LighBlue Bean device.
    /// </summary>
    public partial class Bean : IBean
    {
        private string _name;
        private bool _isDisposed;
        private BeanConnectionStatus _connectionStatus;

        public void Dispose()
        {
            if (_isDisposed)
            {
                throw  new ObjectDisposedException(_name);
            }
            else
            {
                PerformDispose();
                _isDisposed = true;
            }
        }

        public BeanConnectionStatus ConnectionStatus
        {
            get { return _connectionStatus; }
            private set
            {
                if (_connectionStatus != value)
                {
                    _connectionStatus = value;
                    var handler = ConnectionStatusChanged;
                    if (handler != null)
                    {
                        handler(this, new BeanConnectionEventArgs(_connectionStatus));
                    }
                }
            }
        }

        public event EventHandler<BeanConnectionEventArgs> ConnectionStatusChanged;
    }
}