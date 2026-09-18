using UnityEngine;
using Zenject;

public class PlayerHealth : MonoBehaviour
{
    private HealthBar _healthBar;

    [Inject]
    public void Construct(HealthBar healthBar)
    {
        _healthBar = healthBar;
    }
}
