using UnityEngine;
using Zenject;

public class BootStrapInstaller : MonoInstaller

{
    public override void InstallBindings()
    {
        Container.Bind<IAudioService>().To<AudioService>().AsSingle();
    }
}
