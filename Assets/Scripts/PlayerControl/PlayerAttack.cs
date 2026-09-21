using UnityEngine;
using Zenject;

public class PlayerAttack : MonoBehaviour, IAttack
{
    private GameObject _bullet;
    private PlayerGun _gun;
    [SerializeField] private float _bulletSpeed;

    private int bulletCount;
    private GameObject _currentBullet;

    [Inject]
    private void Construct(Settings settings, PlayerGun gun)
    {
        _bullet = settings.bullet;
        _bulletSpeed = settings.bulletSpeed;
        _gun = gun;
    }



    public void Attack()
    {
        _currentBullet = Instantiate(_bullet, _gun.transform.position, Quaternion.identity);


        Rigidbody currentVelocity = _currentBullet.GetComponent<Rigidbody>();
        currentVelocity.linearVelocity = _gun.transform.up * _bulletSpeed;
        bulletCount++;
        Destroy(_currentBullet, 1);
    }
}
