using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts : MonoBehaviour
{
    public int score;
    public bool isMulti;
    [SerializeField] Text scoreText;

    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false; // isMulti берет значение из PlayerPrefs, если там 1, то true, иначе false
    }

    private void OnTriggerEnter2D(Collider2D other) // метод срабатывает, когда объект игрока входит в зону триггера другого объекта.
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            if (isMulti)
                score += 2;
            else
                score++;

        }

        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score); // сохранение очков игрока
            SceneManager.LoadScene(2);
        }

        /* // обнулять счетчик при контакте с врагом
         if (other.gameObject.tag == "Enemy")
         {
             Destroy(other.gameObject);
             score = 0;
          }
        */
    }

    void Update()
    {
        scoreText.text = score.ToString(); //обновляет текстовое поле scoreText с текущим значением переменной score в виде строки, чтобы отобразить текущий счет игрока.
    }
}
