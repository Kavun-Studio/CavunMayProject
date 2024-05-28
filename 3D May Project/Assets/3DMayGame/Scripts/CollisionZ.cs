using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieDamage = 1;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Animator _animator;



    public void Start()
    {
        health = GetComponent<PlayerHealth> ();
        _animator = GetComponent<Animator> ();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {

            Damage();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("Damage", 2f);
        }
        if (collision.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }

    public void Update()
    {
        if(health.currentHealth <= 0)
        {
            _animator.SetBool("Death", true);
            Invoke(nameof(DestroyPlayer), 3f);
            
        }      
    }
    private void DestroyPlayer()
    {
        Destroy(gameObject);
    }

    private void Damage()
    {
        health.currentHealth -= zombieDamage;
    }  
}
