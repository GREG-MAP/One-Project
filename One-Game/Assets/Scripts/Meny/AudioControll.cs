using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioControll : MonoBehaviour
{
    public string volumeParameter = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;

    public float _volumeValue;
    private const float _multiplier = 20f;

    private void Awake()
    {
        slider.onValueChanged.AddListener(ValueChange);
    }
    private void Start()
    {
        _volumeValue = PlayerPrefs.GetFloat(volumeParameter, Mathf.Log10(slider.value) * _multiplier);
        slider.value = Mathf.Pow(10f, _volumeValue / _multiplier);
    }

    private void ValueChange(float value)
    {
        _volumeValue = Mathf.Log10(value) * _multiplier;
        mixer.SetFloat(volumeParameter, _volumeValue);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, _volumeValue);
    }
}
