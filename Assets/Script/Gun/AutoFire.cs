
using UnityEngine;

public class AutoFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float fireRate;
    float fireTimer;

    void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= 1f / fireRate)
        {
            Shoot();
            fireTimer = 0f;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;
    }
}
