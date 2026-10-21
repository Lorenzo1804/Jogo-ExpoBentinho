using UnityEngine;

[RequireComponent(typeof(PlayerStats))]
public class AutoAim : MonoBehaviour
{
		PlayerStats stats;

		[SerializeField] float _range;
		[SerializeField] float _interval = 0.1f;
		[SerializeField] LayerMask _layer;
		float timer;

		private void Awake()
		{
				stats = GetComponent<PlayerStats>();
		}

		private void Update()
		{
				timer -= Time.deltaTime;

				if (timer <= 0f)
				{
						stats.target = FindClosestEnemy();
						timer = _interval;
				}

				if (stats.target == null)
						return;

				Vector2 direction = stats.target.transform.position - transform.position;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.Euler(0f, 0f, angle);
		}

		GameObject FindClosestEnemy()
		{
				Collider2D[] enemies = Physics2D.OverlapCircleAll(
						transform.position,
						_range, _layer
				);

				GameObject closest = null;
				float minDistance = Mathf.Infinity;

				foreach (Collider2D enemy in enemies)
				{
						float distance = (enemy.transform.position - transform.position).sqrMagnitude;

						if (distance < minDistance)
						{
								minDistance = distance;
								closest = enemy.gameObject;
						}
				}

				return closest;
		}
}