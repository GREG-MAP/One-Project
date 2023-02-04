using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMuteGame : MonoBehaviour
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
            audiomixer.SetFloat("Game", 0f);
        }
        else
        {
            audiomixer.SetFloat("Game", -80f);
        }
    }
}
