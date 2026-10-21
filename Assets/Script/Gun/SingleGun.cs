using UnityEngine;

public class SingleGun : Gun
{
		[SerializeField] Bullet prefab;
		[SerializeField] Transform cannon;

		private void Awake()
		{
				cannon = transform.GetChild(0);
		}

		protected override void Shoot()
		{
				Instantiate(prefab, cannon.position, cannon.rotation);
		}
}