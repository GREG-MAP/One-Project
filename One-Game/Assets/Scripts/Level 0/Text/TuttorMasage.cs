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

    private IEnumerator MasageLoader()
    {
        for(_alphastart = 0.0005f; _alphastart < 1.2f; _alphastart += 0.05f)
        {
            _tt.gameObject.GetComponent<CanvasGroup>().alpha = _alphastart + _alphastart;

            yield return new WaitForSeconds(0.1f);

            Debug.Log("Wath ?");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _tt.gameObject.SetActive(true);

        StartCoroutine(MasageLoader());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _tt.gameObject.SetActive(false);
    }
}
