using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMuteButtons : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Toggle _tg;

    void Start()
    {
        _tg.isOn = PlayerPrefs.GetInt("toggleKey") == 0;
    }
    public void musicof()
    {
        if (_tg.isOn)
        {
            audiomixer.SetFloat("Buttons", 0f);
        }
        else
        {
            audiomixer.SetFloat("Buttons", -80f);
        }
    }
}
