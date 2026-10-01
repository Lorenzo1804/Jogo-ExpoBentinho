using UnityEngine;

[RequireComponent (typeof(Rigidbody2D), typeof(PlayerStats))]
public class PlayerMov : MonoBehaviour
{
    PlayerStats stats;
    Rigidbody2D body;
    Vector2 direction;

		private void Awake()
		{
				body = GetComponent<Rigidbody2D>();
        stats = GetComponent<PlayerStats>();
		}

		void Update()
    {
				direction.x = Input.GetAxisRaw("Horizontal");
				direction.y = Input.GetAxisRaw("Vertical");

				direction.Normalize();
    }

    // o "FixedUpdate" atualiza uma determinada quantidade de vezes por quadro, sendo melhor pra mexer com movimentação topdown (eu acho)
    void FixedUpdate()
    {
        Vector2 next = Bounds.instance.Lock(body.position + stats.speed * Time.fixedDeltaTime * direction);
        // posição do rigidbody (player) + movimento normalizado (para evitar aceleração diagonal) * velocidade * tempo
        body.MovePosition(next);
    }
}
