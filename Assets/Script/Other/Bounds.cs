using UnityEngine;

public class Bounds : MonoBehaviour
{
		public static Bounds instance { get; private set; }
		public Transform leftUp, rightDown;

		private void Awake()
		{
				instance = this;
				leftUp = transform.GetChild(0);
				rightDown = transform.GetChild(1);
		}

		public Vector2 Lock(Vector2 position)
		{
				position.x = Mathf.Clamp(
						position.x,
						leftUp.position.x,
						rightDown.position.x
				);

				position.y = Mathf.Clamp(
						position.y,
						rightDown.position.y,
						leftUp.position.y
				);

				return position;
		}
}