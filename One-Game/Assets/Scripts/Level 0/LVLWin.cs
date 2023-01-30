using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLWin : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
   
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rigidbody2D.transform.position = new Vector2(-15, 10);
    }

    private void FixedUpdate()
    {
       
    }
}
