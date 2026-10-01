using UnityEngine;
[RequireComponent(typeof(Collider2D), typeof(PlayerStats))]
public class PlayerLife : MonoBehaviour
{
    public ChangeScene changer;

    PlayerStats stats;

    void Awake()
    {
        if (changer == null) { Debug.LogError("ChangeScene não atribuído no Player"); }
				stats = GetComponent<PlayerStats>();
    }
}