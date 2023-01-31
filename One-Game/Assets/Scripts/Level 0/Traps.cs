using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    [SerializeField] private Collider2D cl;
    [SerializeField] private float speed = 3f;

    private bool H = true;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cl.transform.position = new Vector2(-1500, 10);
    }

    private void FixedUpdate()
    {
   
        if(H == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Time.deltaTime * speed);
        }

        if(transform.position.y < 9.5f)
        {
            transform.position = new Vector2(transform.position.x, 9.5f);

            H = false;

        }else if(H == false)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Time.deltaTime * speed);
        }

        if(transform.position.y > 20)
        {
            transform.position = new Vector2(transform.position.x, 20);

            H = true;
        }

    }
}
