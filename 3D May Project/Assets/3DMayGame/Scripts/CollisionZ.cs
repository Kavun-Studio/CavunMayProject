using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieDamage = 1;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Transform player;
    [SerializeField] private Animator _animator;



    public void Start()
    {
        health = GetComponent<PlayerHealth>();
        _animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Damage();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("Damage", 1f);
        }
        
    }

    public void Update()
    {
        if (health.currentHealth <= 0)
        {
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
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
