using Unity.VisualScripting;
using UnityEngine;

public class Z_Follow : Souds
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform player;
    [SerializeField] private Transform enemy;
    private Animator _animator;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (player != null)
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed);
        else 
        enemy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        
        if(gameObject == null)
        {
            PlaySound(4, destroyed: true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerAttak")
        {
            PlaySound(0, p1: 0.5f, p2: 2f);
            _animator.SetTrigger("Attak");
        }
    }
    
}

