using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [HeaderAttribute("Movement Variables in Y")]
    public float speedY;
    private Rigidbody2D _compRigidbody2D;
    Vector3 refenciaAngle;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Wall") || collider.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        _compRigidbody2D.velocity = refenciaAngle * speedY;
    }
    public void SetAngleBullet(Vector3 xd)
    {
        refenciaAngle = xd;
    }
}
