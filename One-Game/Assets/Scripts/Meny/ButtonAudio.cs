using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource visitFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public void HoverSound()
    {
        visitFX.PlayOneShot(hoverFX);
    }

    public void ClikSound()
    {
        visitFX.PlayOneShot(clickFX);
    }
   

}
