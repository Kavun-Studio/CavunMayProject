using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab; // Префаб снаряда
    [SerializeField] private Transform gunEnd; // Конец ствола оружия
    [SerializeField] private Transform enemyHead; // Голова врага

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        enemyHead = GameObject.FindGameObjectWithTag("enemyHead").GetComponent<Transform>();
        
    }

    void Shoot()
    {
        // Создаем снаряд
        GameObject bulletGO = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        // Если пуля была успешно создана, устанавливаем ее цель
        if (bullet != null)
        {
            bullet.target = enemyHead;
        }
    }
}
public class Bullet : MonoBehaviour
{
    public Transform target;
}
