using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(0, 0, -600);
    public float speed = 5f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, pointB) < 0.01f)
        {
            transform.position = pointA;
        }
    }
}
