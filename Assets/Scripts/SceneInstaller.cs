using TMPro;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private Settings settings;
    

    public override void InstallBindings()
    {
        Container.Bind<Settings>().FromInstance(settings).AsSingle();

        Container.Bind<PlayerGun>().FromComponentInHierarchy().AsSingle();
    }
}
