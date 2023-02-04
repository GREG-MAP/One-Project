using UnityEngine;

public class InclineRun : MonoBehaviour
{
    public GameObject go;
    public string PlayerMove;
    private void OnTriggerEnter2D(Collider2D other)
    {
        (go.GetComponent(PlayerMove) as MonoBehaviour).enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        (go.GetComponent(PlayerMove) as MonoBehaviour).enabled = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        go.GetComponent<PlayerMove>().rb.velocity = new Vector2(20, go.GetComponent<PlayerMove>().rb.velocity.y);
    }
}
