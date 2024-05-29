using UnityEngine;
using UnityEngine.UI;

namespace DefaultNameSpace
{

    [RequireComponent(typeof(Rigidbody))]
    public class WlalkPlayer : MonoBehaviour
    {
        [SerializeField] private float speed = 2.5f;
        public int coins;
        [SerializeField] private PlayerHealth health;
        public bool isMouseDown;
        public Text ammoText;
        private Animator _animator;
        public string enemyTag = "Enemy";


        private void Start()
        {
            _animator = GetComponent<Animator>();
        }
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Coin")
            {
                coins += 10;
                ammoText.text = coins.ToString();
                Destroy(other.gameObject);
            }          
        }

        void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.S))
        {
            verticalInput = 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = 1f;
        }

            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
            transform.Translate(movement, Space.Self);

            _animator.SetBool("isWalk", verticalInput < 0f);


            if (coins > 0 && Input.GetMouseButtonDown(0))
            {
                _animator.SetBool("gun", true);
                coins -= 1;
                ammoText.text = coins.ToString();              
                
            }
            else _animator.SetBool("gun", false);



            if (coins > 0 && Input.GetMouseButtonDown(0))
            {
                GameObject closestEnemy = FindClosestEnemy();

                if (closestEnemy != null)
                {
                    Destroy(closestEnemy);
                }

                GameObject FindClosestEnemy()
                {
                    GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag); // Находим всех врагов с тегом "enemy"

                    GameObject closestEnemy = null;
                    float closestDistance = Mathf.Infinity;
                    Vector3 position = transform.position;

                    foreach (GameObject enemy in enemies)
                    {
                        float distance = Vector3.Distance(position, enemy.transform.position);

                        if (distance < closestDistance)
                        {
                            closestEnemy = enemy;
                            closestDistance = distance;
                        }
                    }

                    return closestEnemy;
                }
            }
        }
            
    }

}

