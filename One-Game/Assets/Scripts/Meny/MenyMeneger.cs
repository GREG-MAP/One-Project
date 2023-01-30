using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenyMeneger : MonoBehaviour
{
    public GameObject settingspanel;


    public void PalayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }

    public void SettingsPanel()
    {
        settingspanel.SetActive(true);
    }

    public void Exit ()
    {
        settingspanel.SetActive(false);
    }
}
