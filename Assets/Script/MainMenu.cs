using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    public void QuitGame ()
    {
        Debug.Log ("QUIT");
        Application.Quit();
    }
}
