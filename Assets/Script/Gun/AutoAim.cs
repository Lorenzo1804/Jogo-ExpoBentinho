using UnityEngine;

public class AutoAim : MonoBehaviour
{
		[SerializeField] float detectionRange;
		[SerializeField] float detectionInterval = 0.1f;
		[SerializeField] LayerMask enemyLayer;

		GameObject target;
		float detectionTimer;

		private void Update()
		{
				detectionTimer -= Time.deltaTime;

				if (detectionTimer <= 0f)
				{
						target = FindClosestEnemy();
						detectionTimer = detectionInterval;
				}

				if (target == null)
						return;

				Vector2 direction = target.transform.position - transform.position;
				float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.Euler(0f, 0f, angle);
		}

		GameObject FindClosestEnemy()
		{
				Collider2D[] enemies = Physics2D.OverlapCircleAll(
						transform.position,
						detectionRange,
						enemyLayer
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