using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ���������� ��������� ����
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    private void Start()
    {
        // ���������� ����� ����� ������ ����
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();

        // ���� ���� - ��������� ����� ��� ������ ������ � ����
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
