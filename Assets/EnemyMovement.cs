using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] pPoints;
    public float enemySpeed;
    public int enemyDestination;
    void FixedUpdate()
    {
        if (enemyDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, pPoints[0].position, enemySpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, pPoints[0].position) < .2f)
            {
                enemyDestination = 1;
            }
        }
        if (enemyDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, pPoints[1].position, enemySpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, pPoints[1].position) < .2f)
            {
                enemyDestination = 0;
            }
        }
    }
}
