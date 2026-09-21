using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Scriptable Objects/Settings")]
public class Settings : ScriptableObject
{
    [Header("Health")]
    public float playerMaxHealth;
    public float enemyMaxHealth;

    [Header("Damage")]
     public float bulletDamage;

    [Header("PlayerStats")]
     public int jumpForce;
     public LayerMask groundMask;
     public float movementSpeed;
     public GameObject bullet;
     public float bulletSpeed;

}
