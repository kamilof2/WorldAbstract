using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        Application.Quit();
    }

}
