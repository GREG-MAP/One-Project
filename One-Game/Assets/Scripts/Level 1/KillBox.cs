using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    [SerializeField] private DeathScrineKillBox ds;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent(out PlayerMove pm))
        {
            pm.transform.gameObject.SetActive(false);

            ds.DeathSc();
        }
    }
}
