using TMPro;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private Settings settings;
    [SerializeField] private BehaviourManager _chasingEnemy;
    [SerializeField] private GameObject[] _patrolPoints;
    [SerializeField] private GameObject[] _hideTargets;
    

    public override void InstallBindings()
    {
        Container.Bind<Settings>().FromInstance(settings).AsSingle();

        Container.Bind<PlayerGun>().FromComponentInHierarchy().AsSingle();

        Container.BindFactory<BehaviourManager, ChasingEnemyFactory>().FromComponentInNewPrefab(_chasingEnemy);

        Container.Bind<GameObject[]>().FromInstance(_patrolPoints).AsCached().WhenInjectedInto<PatrolBehaviour>();

        Container.Bind<GameObject[]>().FromInstance(_hideTargets).AsCached().WhenInjectedInto<HideBehaviour>();
    }
}
