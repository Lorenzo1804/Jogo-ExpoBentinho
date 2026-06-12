using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life;

    public void TakeDamage(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}