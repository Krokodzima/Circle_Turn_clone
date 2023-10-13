using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopAssist : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public bool isMulti = false; // наличие множителя

    void Start()
    {
        money = PlayerPrefs.GetInt("Money"); // система сохранения 
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = money.ToString();
    }

    public void BuyMulti() // метод, отвечающий за покупку множителя Х2
    {
        if (money >= 10 && isMulti == false) // проверка количества денег и наличие множителя
        {
            isMulti = true;
            money -= 10;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0); // тернарная операция: Если isMulti = true (1), иначе (:) = false (0)
        }
    }

    public void ExitShop()
    {
        SceneManager.LoadScene(0);
    }
}
