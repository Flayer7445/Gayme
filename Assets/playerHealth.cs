using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;


    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
