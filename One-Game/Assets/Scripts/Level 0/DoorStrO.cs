using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStrO : MonoBehaviour
{
    float speed = 3f;
    bool MoveDoor = true;
    void Start()
    {
    
    }


    private void FixedUpdate()
    {

       if(transform.position.y > 23)
        {
            MoveDoor = false;

        }

       if(MoveDoor)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
    }
}
