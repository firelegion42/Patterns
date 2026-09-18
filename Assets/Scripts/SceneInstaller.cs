using TMPro;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private HealthBar _healthBar;

    public override void InstallBindings()
    {
        Container.Bind<HealthBar>().FromInstance(_healthBar).AsSingle();
    }
}
