using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    
    [SerializeField] GameObject enemy;
    [SerializeField] float sizeX = 1f;
    [SerializeField] float sizeY = 1f;
    [SerializeField] float spawnCooldown = 1f;
    
    private float spawnTime;

     void Start()
    {
        spawnTime = spawnCooldown;
    }

    void Update()
    {
        if (spawnTime > 0) spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Spawn();
            spawnTime = spawnCooldown;
        }
    }

    void Spawn()
    {
        float xPos = (Random.value - 0.5f)* 2 * sizeX + gameObject.transform.position.x;
        float yPos = (Random.value - 0.5f)* 2 * sizeY + gameObject.transform.position.y;

        var spawn = Instantiate(enemy);

        spawn.transform.position = new Vector3(xPos, yPos, 0);
    }
}
