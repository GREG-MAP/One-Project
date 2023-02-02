using UnityEngine;

public class DoorOpTrG : MonoBehaviour
{
    float speed = 5f;
    [SerializeField] bool MoveDoor = true;
    [SerializeField] public Collider2D cl;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (cl.transform.position.y > 23)
        {
            MoveDoor = false;
        }

        if (MoveDoor == true)
        {
            cl.transform.position = new Vector2(cl.transform.position.x, cl.transform.position.y + speed * Time.deltaTime);
        }else if (cl.transform.position.y < 14.6)
        {
            MoveDoor = true;
        }

    }


}
