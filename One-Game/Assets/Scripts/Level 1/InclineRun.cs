using UnityEngine;

public class InclineRun : MonoBehaviour
{
    public GameObject go;
    public string PlayerMove;
    private float _speed = 20f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        (go.GetComponent(PlayerMove) as MonoBehaviour).enabled = false;
        go.GetComponent<PlayerMove>().speed = _speed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        (go.GetComponent(PlayerMove) as MonoBehaviour).enabled = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        go.GetComponent<PlayerMove>().rb.velocity = new Vector2(go.GetComponent<PlayerMove>().speed, go.GetComponent<PlayerMove>().rb.velocity.y);
    }
}
