using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public playerHealth pHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pHealth.TakeDamage(damage);
        }
    }

}
