using UnityEngine;

public class DoorClTrG : MonoBehaviour
{
    float speed = 5f;
    [SerializeField] bool MoveDoor = true;
    [SerializeField] public Collider2D cl;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (cl.bounds.center.y < 14.6)
        {
            MoveDoor = false;
        }

        if (MoveDoor == true)
        {
            cl.transform.position = new Vector2(cl.transform.position.x, cl.transform.position.y - speed * Time.deltaTime);
        }

        if (cl.bounds.center.y > 14.6)
        {
            MoveDoor = true;
        }
    }
}
