using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTurretController : MonoBehaviour
{
    public GameManagerController gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        GameObject newTurret = Instantiate(gameManager.currentTurret, transform.position, transform.rotation);
        newTurret.GetComponent<TurretMovementController>().enabled = false;
        newTurret.GetComponent<TurretController>().enabled = true;
        Destroy(gameManager.currentTurret);
        gameManager.currentTurret = null;
        print("me estoy colocando");
    }
}
