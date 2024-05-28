using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform Player;
    Vector3 Target;
    [SerializeField] private float TrakingSpeed = 0.25f;

    private void Update()
    {
        if (Player)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, Target, TrakingSpeed * Time.deltaTime);
            transform.position = currentPosition;

            Target = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
        }
    }
}

