using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerController : MonoBehaviour
{
    public GameObject turret1Prefab;
    public GameObject turret2Prefab;
    public GameObject turret3Prefab;
    public GameObject currentTurret;
    public Text textPoints;
    public Text textCoins;
    public Text textLife;
    private int points;
    private int coins;
    public int vidaActual;

    void Start()
    {
        UpdatePoints(0);
        UpdateCoins(100);
    }
    public void UpdatePoints(int score)
    {
        points = points + score;
        textPoints.text = "Puntos: " + points;
        if (points >= 300)
        {
            SceneManager.LoadScene("Winner");
        }
    }
    /*public void UpdateLife(int vida)
    {
        vidaActual = vidaActual - vida;
        textLife.text = "Vida: " + vidaActual;
        if (vida <= 0)
        {
            print("has perdido");
            //SceneManager.LoadScene("GameOver");
        }
    }*/
    public void UpdateCoins(int monedas)
    {
        coins = coins + monedas;
        textCoins.text = "Monedas: " + coins;
    }
    void Update()
    {

    }
    public void GoMenu()
    {
        SceneManager.LoadScene("StarScene");
    }
    public void CreateTurret1()
    {
        if (coins >= 25)
        {
            if (currentTurret == null)
            {
                currentTurret = Instantiate(turret1Prefab, transform.position, transform.rotation);
                coins -= 25;
                UpdateCoins(0);
            }
        }
    }
    public void CreateTurret2()
    {
        if (coins >= 50)
        {
            if (currentTurret == null)
            {
                currentTurret = Instantiate(turret2Prefab, transform.position, transform.rotation);
                coins -= 50;
                UpdateCoins(0);
            }
        }
    }
    public void CreateTurret3()
    {
        if (coins >= 75)
        {
            if (currentTurret == null)
            {
                currentTurret = Instantiate(turret3Prefab, transform.position, transform.rotation);
                coins -= 75;
                UpdateCoins(0);
            }
        }
    }
}
