using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _health;
    public int health => _health;

    [SerializeField] float _speed;
    public float speed => _speed;
}

