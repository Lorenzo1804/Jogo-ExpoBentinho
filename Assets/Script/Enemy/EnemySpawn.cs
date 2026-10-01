using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
		[SerializeField] GameObject prefab;
		[SerializeField] Transform center;
		[SerializeField] float innerRadius, outerRadius;
		[SerializeField] float interval;
		float timer;

		private void Awake()
		{
				if (prefab == null)
				{ Debug.LogError("Enemy prefab not defined"); }
				if (center == null)
				{ Debug.LogError("Enemy spawn center not defined"); }
		}

		private void Update()
		{
				timer -= Time.deltaTime;

				if (timer <= 0f)
				{
						Spawn();
						timer = interval;
				}
		}

		public void Spawn()
		{
				Vector2 direction = Random.insideUnitCircle.normalized;
				float distance = Random.Range(innerRadius, outerRadius);

				Vector3 spawnPosition = center.position;

				spawnPosition.x += direction.x * distance;
				spawnPosition.y += direction.y * distance;

				// if spawn would be out of screen, try to adjust
				// if after adjusted, the spawn position
				// is too near the center skip this spawn
				spawnPosition = Bounds.instance.Lock(spawnPosition);
				if (Vector2.Distance(spawnPosition, center.position) < innerRadius) { return; }

				Instantiate(prefab, spawnPosition, Quaternion.identity);
		}
}