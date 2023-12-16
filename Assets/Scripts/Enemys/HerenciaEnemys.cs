using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerenciaEnemys : MonoBehaviour
{
    protected float speed = 0.5f;
    [SerializeField] protected int damage;
    [SerializeField]protected int points;
    protected Animator _compAnimator;
    protected Rigidbody2D _compRigidbody2D;
    public GameManagerController gameManager;
    [SerializeField] protected string deathAnimationTrigger;

    public int index;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    protected virtual void VelocidadEnemy()
    {
        _compRigidbody2D.velocity = new Vector2(speed, 0);
    }   
    protected virtual void Start()
    {
        this.VelocidadEnemy();
    }
    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("House"))
        {
            gameManager.UpdateLife(damage); // agregacion
            _compAnimator.SetTrigger(deathAnimationTrigger); //agregacion
            Destroy(this.gameObject, 0.6f);
            GetComponent<BoxCollider2D>().enabled = false;
            _compRigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
        if (collider.CompareTag("Bullet"))
        {
            gameManager.UpdatePoints(points); //agreacion
            gameManager.UpdateCoins(10); //agregacion
            _compAnimator.SetTrigger(deathAnimationTrigger);  
            Destroy(this.gameObject, 0.6f);
            GetComponent<BoxCollider2D>().enabled = false;
            _compRigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX ; 
        }
    }
    protected virtual void Update()
    {
    }
}
