
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
