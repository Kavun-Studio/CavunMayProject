using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField] Text moneyText;
    public int money;
    [SerializeField] GameObject LockSystem1;
    [SerializeField] GameObject Use1;
    [SerializeField] GameObject LockSystem2;
    [SerializeField] GameObject Use2;
    [SerializeField] GameObject LockSystem3;
    [SerializeField] GameObject Use3;
    [SerializeField] GameObject LockSystem4;
    [SerializeField] GameObject Use4;
    [SerializeField] GameObject LockSystem5;
    [SerializeField] GameObject Use5;
    public int buy1, buy2, buy3, buy4, buy5;


    private void Start()
    {
        money += Score.moneyformenu;
        moneyText.text = money.ToString();

        if (PlayerPrefs.HasKey("money"))
        {
        money = PlayerPrefs.GetInt("money");
        }

        PlayerPrefs.GetString("money", moneyText.text);
        PlayerPrefs.Save();


        if (PlayerPrefs.HasKey("1"))
            buy1 = PlayerPrefs.GetInt("1");

        if (PlayerPrefs.HasKey("2"))
            buy1 = PlayerPrefs.GetInt("2");

        if (PlayerPrefs.HasKey("3"))
            buy1 = PlayerPrefs.GetInt("3");

        if (PlayerPrefs.HasKey("4"))
            buy1 = PlayerPrefs.GetInt("4");

        if (PlayerPrefs.HasKey("5"))
            buy1 = PlayerPrefs.GetInt("5");

        if (buy1 == 1)
        {
            LockSystem1.SetActive(false);
            Use1.SetActive(true);
        }
        if (buy2 == 1)
        {
            LockSystem2.SetActive(false);
            Use2.SetActive(true);
        }
        if (buy3 == 1)
        {
            LockSystem3.SetActive(false);
            Use3.SetActive(true);
        }
        if (buy4 == 1)
        {
            LockSystem4.SetActive(false);
            Use4.SetActive(true);
        }
        if (buy5 == 1)
        {
            LockSystem5.SetActive(false);
            Use5.SetActive(true);
        }
    }
  



    public void BuySystem1()
    {
        if (money >= 200)
        {
            buy1 = 1;
            PlayerPrefs.SetInt("1", buy1);
            PlayerPrefs.Save();
            LockSystem1.SetActive(false);
            Use1.SetActive(true);
            money -= 200;
        }


    }
    public void BuySystem2()
    {
        if (money >= 500)
        {
            buy2 = 1;
            PlayerPrefs.SetInt("2", buy2);
            PlayerPrefs.Save();
            LockSystem2.SetActive(false);
            Use2.SetActive(true);
            money -= 500;
        }


    }
    public void BuySystem3()
    {
        if (money >= 800)
        {
            buy3 = 1;
            PlayerPrefs.SetInt("3", buy3);
            PlayerPrefs.Save();
            LockSystem3.SetActive(false);
            Use3.SetActive(true);
            money -= 800;
        }


    }
    public void BuySystem4()
    {
        if (money >= 1000)
        {
            buy4 = 1;
            PlayerPrefs.SetInt("4", buy4);
            PlayerPrefs.Save();
            LockSystem4.SetActive(false);
            Use4.SetActive(true);
            money -= 1000;
        }


    }
    public void BuySystem5()
    {
        if (money >= 1500)
        {
            buy5 = 1;
            PlayerPrefs.SetInt("5", buy5);
            PlayerPrefs.Save();
            LockSystem5.SetActive(false);
            Use5.SetActive(true);
            money -= 1500;
        }


    }
}

