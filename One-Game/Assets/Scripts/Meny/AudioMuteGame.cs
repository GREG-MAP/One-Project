using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMuteGame : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Toggle _tg;
    private AudioControll _ac;

    private float vv;

    void Start()
    {
        _tg.isOn = PlayerPrefs.GetInt("toggleKey") == 0;

        _ac._volumeValue = vv;
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
