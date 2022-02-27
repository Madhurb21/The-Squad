using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Final3");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsScreen");
    }

    public void Credits()
    {
        SceneManager.LoadScene("CreditsScreen");
    }
}
