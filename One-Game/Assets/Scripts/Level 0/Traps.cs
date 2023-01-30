using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rigidbody2D.transform.position = new Vector2(-1500, 10);
    }

    private void FixedUpdate()
    {
       
    }
}
