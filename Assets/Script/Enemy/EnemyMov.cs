using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    private Transform playerPos;
    [SerializeField] float speed;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
       FollowPlayer(); 
    }

    private void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }
}
