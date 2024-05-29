using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 2;

    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
