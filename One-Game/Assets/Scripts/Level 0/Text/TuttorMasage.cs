using System.Collections;
using UnityEngine;

public class TuttorMasage : MonoBehaviour
{
    [SerializeField] private GameObject _tt;
    private float _alphastart = 0.1f;

    private void Awake()
    {
        _tt.gameObject.GetComponent<CanvasGroup>().alpha = _alphastart;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _tt.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _tt.gameObject.SetActive(false);
    }
}
