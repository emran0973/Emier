using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Assign in the Inspector
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null)
        {
            Debug.LogError("Bullet prefab is not assigned!");
            return;
        }

        // Instantiate the bullet and add a Rigidbody for movement
        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb == null)
        {
            rb = bullet.AddComponent<Rigidbody>();
        }

        rb.useGravity = false; // Ensure gravity is off for bullets
        rb.linearVelocity = transform.forward * bulletSpeed;

        Destroy(bullet, 2f); // Destroy the bullet after 2 seconds
    }
}