using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1; // Damage dealt by the bullet

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object hit has the ZombieHealth component
        ZombieHealth zombie = collision.gameObject.GetComponent<ZombieHealth>();
        if (zombie != null)
        {
            // Deal damage to the zombie
            zombie.TakeDamage(damage);

            // Destroy the bullet after hitting the zombie
            Destroy(gameObject);
        }

        // Optional: Destroy the bullet if it hits something else
        else
        {
            Destroy(gameObject);
        }
    }
}
