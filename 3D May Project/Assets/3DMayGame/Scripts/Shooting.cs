using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab; // ������ �������
    [SerializeField] private Transform gunEnd; // ����� ������ ������
    [SerializeField] private Transform enemyHead; // ������ �����

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
        // ������� ������
        GameObject bulletGO = Instantiate(bulletPrefab, gunEnd.position, gunEnd.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        // ���� ���� ���� ������� �������, ������������� �� ����
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
