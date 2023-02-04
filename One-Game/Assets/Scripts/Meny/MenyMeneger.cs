using UnityEngine;
using UnityEngine.SceneManagement;

public class MenyMeneger : MonoBehaviour
{
    public GameObject settingspanel;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void SettingsPanel()
    {
        settingspanel.SetActive(true);
    }

    public void Exit ()
    {
        settingspanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
