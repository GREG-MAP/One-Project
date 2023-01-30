using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource visitFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;



    public void HoverSound()
    {
        visitFX.PlayOneShot(hoverFX);
    }

    public void ClikSound()
    {
        visitFX.PlayOneShot(clickFX);
    }
   

}
