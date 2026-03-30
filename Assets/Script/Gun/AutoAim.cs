
using UnityEngine;

public class AutoAim : MonoBehaviour
{
    public float detectionRange;

    GameObject target;

    void Update()
    {
        target = FindClosestEnemy();

        if (target != null)
        {
            Vector2 dir = (target.transform.position - transform.position).normalized;
            float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);// - 90f;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    GameObject FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;

        float minDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);

            if (distance < minDistance && distance <= detectionRange)
            {
                minDistance = distance;
                closest = enemy;
            }
        }

        return closest;
    }
}
