using UnityEngine;

public class DoubleGun : Gun
{
		[SerializeField] Bullet prefab;
		[SerializeField] Transform upperCannon;
		[SerializeField] Transform lowerCannon;

		private void Awake()
		{
				upperCannon = transform.GetChild(0);
				lowerCannon = transform.GetChild(1);
		}

		protected override void Shoot()
		{
				Instantiate(prefab, upperCannon.position, upperCannon.rotation);
				Instantiate(prefab, lowerCannon.position, lowerCannon.rotation);
		}
}