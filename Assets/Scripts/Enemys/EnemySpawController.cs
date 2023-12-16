using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawController : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    [HeaderAttribute("Time Spawn enemys")]
    public float generationTime = 3;
    private float rndX;
    private float rndY = -0.53f;
    public float timeElapsed = 0;       
    int randomPrefab = 0;
    int count;
    public GameManagerController gameSpawManager;
    void Update()
    {
        timeElapsed = Time.deltaTime + timeElapsed;
        
        if (timeElapsed >= generationTime)
        {
            GenerarRandom();
            GenerarEnemigo();
            timeElapsed = 0;
        }   
    }

    void GenerarEnemigo()
    {
        GameObject tmp = Instantiate(enemyPrefab[randomPrefab], new Vector2(rndX, rndY), transform.rotation);
        tmp.GetComponent<HerenciaEnemys>().index = count;
        tmp.GetComponent<HerenciaEnemys>().gameManager = gameSpawManager;
        count++;
    }
    void GenerarRandom()
    {
        rndX = Random.Range(-17.46f, -9.37f);
        randomPrefab= Random.Range(0, enemyPrefab.Length);
    }
}
