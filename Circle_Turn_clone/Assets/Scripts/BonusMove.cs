using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{
    [SerializeField] GameObject bonus;
    [SerializeField] float speedBonus; // модиифкатор скорости


    private void FixedUpdate()
    {
        bonus.transform.Translate(speedBonus * Time.deltaTime, 0, 0); // движение  enemy (х = модициактор скорости * на дельту времени, y = 0, z = 0)
    }




}

