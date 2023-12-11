using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    private float generationTime = 3f;
    private float timeElapsed = 0f;

    public BulletController bulletPrefab;
    Transform positionEnenemyReference;
    Vector3 directionEnmy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (positionEnenemyReference != null)
        {
            directionEnmy = positionEnenemyReference.position - transform.position;

            float angle = Mathf.Atan2(directionEnmy.y, directionEnmy.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0f, 0f, angle + 270);
            if (timeElapsed >= generationTime)
            {
                Instantiate(bulletPrefab, transform.position, transform.rotation).SetAngleBullet(directionEnmy.normalized);
                timeElapsed = 0;
            }
        }
        timeElapsed = Time.deltaTime + timeElapsed;


    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag =="Enemy")
        {
            if (positionEnenemyReference == null)
            {
                positionEnenemyReference = collider.gameObject.transform;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //asociacion
        if (positionEnenemyReference != null) {
            if (collision.gameObject.GetComponent<HerenciaEnemys>().index == positionEnenemyReference.GetComponent<HerenciaEnemys>().index)
            {   
                this.positionEnenemyReference = null;
            }
        }
    }
}
