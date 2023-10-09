using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    bool direction = false; // по умочанию шарик идет против часовой

    void FixedUpdate()
    {
        if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime); //обращаемся к transform.Rotate (х=0б, y=0, z=150 * Time.deltaTime)

        else
            CenterCircle.transform.Rotate(0, 0, -150 * Time.deltaTime); //обращаемся к transform.Rotate (х=0б, y=0, z=-150 * Time.deltaTime)

    }


    public void ChangeDirection()
    { 
        direction = !direction;
    }

}
