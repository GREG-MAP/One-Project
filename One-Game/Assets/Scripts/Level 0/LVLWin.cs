using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLWin : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
   
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.transform.position = new Vector2(-15, 10);
    }

    private void FixedUpdate()
    {
       
    }
}
