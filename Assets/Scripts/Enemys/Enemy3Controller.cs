using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Controller : HerenciaEnemys
{
    // Start is called before the first frame update

    protected override void Start()
    {
        speed = speed + 3;
        _compRigidbody2D.velocity = new Vector2(speed, 0);
    }
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        base.OnTriggerEnter2D(collider);
    }
}
