using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject target;
    public Vector2 distance;
    public float speed;
    Vector2 pos;

    void FixedUpdate()
    {
        pos.x = Mathf.SmoothDamp(transform.position.x, target.transform.position.x, ref distance.x, speed);
        pos.y = Mathf.SmoothDamp(transform.position.y, target.transform.position.y, ref distance.y, speed);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
