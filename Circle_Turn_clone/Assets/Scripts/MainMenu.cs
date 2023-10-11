using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // библиотека менеджера сцен

public class MainMenu : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene(1); // (0) - MainMenu, (1) - PlayScene, (2) - Lose
    }

}
