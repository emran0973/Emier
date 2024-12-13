using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public Transform player; // Assign the player in the Inspector
    public float speed = 2f;
    public float stoppingDistance = 0.1f; // Reduce stopping distance for close contact

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer > stoppingDistance)
        {
            // Move towards the player
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        Debug.Log("Game Over! Zombie touched the player!");
        // Add your game-ending logic here, e.g.:
        // Destroy(collision.gameObject); // Destroy the player
    }
}

}
