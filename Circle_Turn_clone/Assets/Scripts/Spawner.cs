using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos; // позици€ генератора врагов

    [SerializeField] Vector2 range; // диапазон по оси Y в котором допусим спавн врагов
    [SerializeField] GameObject enemy; // враг
    [SerializeField] GameObject bonus; // враг


    void Start() // точка входа - запуск спавна врагов
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.0f); // периодичность с которой выполн€ютс€ действи€
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity); // создаем объект (какой объект, координаты, кватернион с отсутствием вращени€)

        yield return new WaitForSeconds(1.0f);
        Instantiate(bonus, pos, Quaternion.identity); // создаем объект (какой объект, координаты, кватернион с отсутствием вращени€)


        Repeat();
    }

  
    void Repeat() // повтор спавна врагов
    {
        StartCoroutine(Spawn());

    }

}
