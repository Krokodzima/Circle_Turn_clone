using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{
    [SerializeField] GameObject bonus;
    [SerializeField] float speedBonus; // ����������� ��������


    private void FixedUpdate()
    {
        bonus.transform.Translate(speedBonus * Time.deltaTime, 0, 0); // ��������  enemy (� = ����������� �������� * �� ������ �������, y = 0, z = 0)
    }




}

