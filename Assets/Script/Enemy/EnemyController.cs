using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyController : MonoBehaviour {

    protected bool isMoving = false;

    protected Rigidbody2D rigidbody2;
    protected Animator animator;
    protected SpriteRenderer spriteRenderer;
    private int health;

    void Awake()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }  

    void Start()
    {
        
    }

    public void DamangeEnemy(int damageBullet)
    {
        health = health - damageBullet;
        StartCoroutine(Damange());

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    IEnumerator Damange()
    {
            if (spriteRenderer != null)
        {
            spriteRenderer.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.color = Color.white;
        }
        else
        {
            yield return null;
        }
    }
}
