using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTurretController : MonoBehaviour
{
    public GameManagerController gameManager;
    GameObject newTurret = null;
    void OnMouseDown()
    {
        if (newTurret == null)
        {
            try
            {
                newTurret = Instantiate(gameManager.currentTurret, transform.position, transform.rotation);
                newTurret.GetComponent<TurretMovementController>().enabled = false; //asociacion
                newTurret.GetComponent<TurretController>().enabled = true; //asociacion
                Destroy(gameManager.currentTurret);
                gameManager.currentTurret = null;
            }
            catch (System.ArgumentException) { }
        }
    }
}
