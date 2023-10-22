using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    private int nightNumber;

    public GameObject enemy;
    public GameObject[] enemySpawners;

    public InvokeAfterTimer nightTimer;

    public void IncreaseNight()
    {
        nightNumber += 1;
    }

    public void StartWave()
    {
        Debug.Log("Comecou onda");
        StartCoroutine("Wave");
    }

    private IEnumerator Wave()
    {
        Debug.Log("Vai entrar no for");
        for (int i = 0; i < nightNumber + 1; i++)
        {
            Debug.Log("entrou no for e esta em " + i);
            yield return new WaitForSeconds(nightTimer.timeToAction / nightNumber + 2);
            int spawnN = Random.Range(0, enemySpawners.Length);
            Instantiate(enemy, enemySpawners[spawnN].transform.position, transform.rotation);
        }
    }
}
