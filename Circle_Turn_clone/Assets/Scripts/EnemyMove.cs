using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed; // модиифкатор скорости


    private void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0); // движение  enemy (х = модициактор скорости * на дельту времени, y = 0, z = 0)
    }




}
