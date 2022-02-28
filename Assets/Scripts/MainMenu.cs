using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Scorescript.scorezombie1 = 0;
        SceneManager.LoadScene("Controls");
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
