using System;

namespace eDrive.LightBlueBean
{
    public interface IBeanManager : IDisposable
    {
        IObservable<IBean> StartScanForBeans();

    }
}