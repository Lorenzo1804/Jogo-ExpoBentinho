using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 mov;

    void Update()
    {
        // inputs de teste mais simples que usam tanto WASD quanto as setas (mudar depois para apenas WASD)
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");

        mov.Normalize();
    }

    // o "FixedUpdate" atualiza uma determinada quantidade de vezes por quadro, sendo melhor pra mexer com movimentação topdown (eu acho)
    private void FixedUpdate()
    {
        // posição do rigidbody (player) + movimento normalizado (para evitar aceleração diagonal) * velocidade * tempo
        rb.MovePosition(rb.position + mov * speed * Time.fixedDeltaTime);
    }
}
