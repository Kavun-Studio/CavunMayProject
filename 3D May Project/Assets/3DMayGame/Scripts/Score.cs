using UnityEngine;
using UnityEngine.UI;

public class Score : PlayerHealth
{
    [SerializeField] private Transform player;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreTextfordiemenu;
    public static int moneyformenu;
    [SerializeField] private Text money;
    [SerializeField] private GameObject diemenu;
    [SerializeField] private GameObject ammunation;
    [SerializeField] private GameObject score;
    [SerializeField] public int distante;
    [SerializeField] private GameObject moneyMenu;
    [SerializeField] private PlayerHealth health;

    private void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (player != null)
        {
            scoreText.text = ((int)(player.position.z)).ToString();
            distante = ((int)(player.position.z));
        }
        else diemenu.SetActive(true);
        moneyformenu = distante / 2;
        money.text = (distante / 2).ToString();
        scoreTextfordiemenu.text = distante.ToString();

        if (health.currentHealth <= 0)
        {
            ammunation.SetActive(false);
            score.SetActive(false);

        }
    }
}
