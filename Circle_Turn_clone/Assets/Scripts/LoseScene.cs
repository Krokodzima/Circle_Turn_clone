using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ���������� ��������� ����
using UnityEngine.UI; // ���������� UI

public class LoseScene : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score"); // �������� �������� Score �� PlayerPrefs
        scoreText.text = score.ToString();  // ������ �������� Score � ������ score 
    }



    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
