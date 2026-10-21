using UnityEngine;

public class DoubleGunItem : MonoBehaviour, IItem
{
		[SerializeField] DoubleGun gun;

		public void OnGet(PlayerStats player)
		{
				player.AttachGun(gun);
		}
}