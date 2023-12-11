using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : HerenciaEnemys
{
    private float generationTime = 2;
    public float timeElapsed = 0;
    private float normalSpeed;
    private float increasedSpeed; 

    protected override void Start()
    {
        normalSpeed = speed;
        increasedSpeed = normalSpeed * 3.5f;

    }
    protected override void VelocidadEnemy()
    {
        timeElapsed = Time.deltaTime + timeElapsed; 

        if (timeElapsed >= generationTime)
        {
            if (speed == normalSpeed)
            {
                speed = increasedSpeed;
            }
            else
            {
                speed = normalSpeed; 
            }
            timeElapsed = 0;
        }
        _compRigidbody2D.velocity = new Vector2(speed, 0);

    }
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        base.OnTriggerEnter2D(collider);
    }

    protected override void Update()
    {
        base.Update();
        VelocidadEnemy();
    }
}
