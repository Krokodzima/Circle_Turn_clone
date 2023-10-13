using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // библиотека менеджера сцен
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    private void Start()
    {
        // накопление очков после каждой игры
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();

        // фикс бага - получение денег при каждом заходе в игру
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", 0);
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(1); // (0) - MainMenu, (1) - PlayScene, (2) - Lose
    }

    public void ToShop()
    {
        SceneManager.LoadScene(3);
    }
}
