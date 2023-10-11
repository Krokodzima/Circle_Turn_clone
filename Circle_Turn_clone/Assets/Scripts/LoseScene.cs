using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // библиотека менеджера сцен
using UnityEngine.UI; // библиотека UI

public class LoseScene : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score"); // получаем значение Score из PlayerPrefs
        scoreText.text = score.ToString();  // запись значения Score в строку score 
    }



    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
