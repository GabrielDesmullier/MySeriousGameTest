using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelEndMenu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
