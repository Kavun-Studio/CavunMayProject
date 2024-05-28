using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : PlayerHealth
{
    [SerializeField] private Transform player;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreTextfordiemenu;
    [SerializeField] private Text money;
    [SerializeField] private GameObject diemenu;
    [SerializeField] private GameObject ammunation;
    [SerializeField] private GameObject score;
    [SerializeField] private int distante;
    [SerializeField] private GameObject moneyMenu;
    [SerializeField] private PlayerHealth health;

    private void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (player != null)
            scoreText.text = ((int)(player.position.z)).ToString();
        distante = ((int)(player.position.z));
        if (distante == 50)
        money.text = (distante / 50).ToString();
        distante -= 50;

        if (health.currentHealth <= 0)
        {
         
            ammunation.SetActive(false);
            score.SetActive(false);
            diemenu.SetActive(true);
            scoreTextfordiemenu.text = scoreText.text;

        }
    }
}
