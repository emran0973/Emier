using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Player Died!");
            Destroy(gameObject);
        }
    }
}
