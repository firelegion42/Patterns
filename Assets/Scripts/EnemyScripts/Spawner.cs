using UnityEngine;
using Zenject;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minZ;
    [SerializeField] private float _maxZ;

    [Inject]
    private ChasingEnemyFactory enemyFactory;
        
        
        
    public void SummonEnemy()
    {
        Debug.Log("Button Pressed");
        var go = enemyFactory.Create();
        go.transform.position = GetRandomPosition();
    }

    private Vector3 GetRandomPosition()
    {
        var randomX = Random.Range(_minX, _maxX);
        var randomZ = Random.Range(_minZ, _maxZ);
        return new Vector3(randomX, 0f, randomZ);
    }
}
