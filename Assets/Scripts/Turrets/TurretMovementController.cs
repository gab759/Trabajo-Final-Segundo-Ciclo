using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovementController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 truePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = truePosition;
        GetComponent<TurretController>().enabled = false;
    }
}
