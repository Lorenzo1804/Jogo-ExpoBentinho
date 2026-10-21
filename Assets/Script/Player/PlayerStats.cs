using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _health;
    public int health => _health;

    [SerializeField] float _speed;
    public float speed => _speed;

		[SerializeField] public Gun _gun;
		public Gun gun => _gun;

    [SerializeField] Transform _gunTransform;
    public Transform gunTransform => _gunTransform;

    [HideInInspector] public GameObject target;

		public void AttachGun(Gun gun)
		{
				Destroy(_gun);
				_gun = gun;
				gun.transform.parent = gunTransform;
				gun.transform.localPosition = Vector3.zero;
		}

		void OnTriggerEnter2D(Collider2D other)
		{
				if(other.TryGetComponent<IItem>(out IItem item))
				{
						item.OnGet(this);
				}
		}
}

