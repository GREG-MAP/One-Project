using UnityEngine;

public class Incrunoff : MonoBehaviour
{
    [SerializeField] private GameObject incrun;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        incrun.SetActive(false);
    }
}
