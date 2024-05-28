using UnityEngine;

public class Z_Follow : MonoBehaviour
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
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerAttak")
        {
            _animator.SetTrigger("Attak");
        }
    }
}

