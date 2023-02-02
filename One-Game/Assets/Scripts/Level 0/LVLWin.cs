using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLWin : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
   
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            SceneManager.LoadScene("Level 1");
    }

    private void FixedUpdate()
    {
       
    }
}
