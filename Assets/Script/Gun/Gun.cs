using UnityEngine;

public abstract class Gun : MonoBehaviour
{
		[SerializeField] protected float rate;
		protected float timer;

		public void Update()
		{
				Trigger();
		}

		void Trigger()
		{
				timer += Time.deltaTime;

				if (timer >= 1f / rate)
				{
						Shoot();
						timer = 0f;
				}
		}

		protected abstract void Shoot();
}