using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField] Text moneyText;
    public int money;
    [SerializeField] GameObject LockSystem1;
    [SerializeField] GameObject Buy1;
    [SerializeField] GameObject Use1;
    [SerializeField] GameObject LockSystem2;
    [SerializeField] GameObject Buy2;
    [SerializeField] GameObject Use2;
    [SerializeField] GameObject LockSystem3;
    [SerializeField] GameObject Buy3;
    [SerializeField] GameObject Use3;
    [SerializeField] GameObject LockSystem4;
    [SerializeField] GameObject Buy4;
    [SerializeField] GameObject Use4;
    [SerializeField] GameObject LockSystem5;
    [SerializeField] GameObject Buy5;
    [SerializeField] GameObject Use5;
    public static bool buy1;
    public static bool buy2;
    public static bool buy3;
    public static bool buy4;
    public static bool buy5;

    private const string saveKey = "mainSave";

    private void Start()
    {
        Score.moneyformenu += money;
        if (buy1 == true)
        {
            LockSystem1.SetActive(false);
            Buy1.SetActive(false);
            Use1.SetActive(true);
        }
        if (buy2 == true)
        {
            LockSystem2.SetActive(false);
            Buy2.SetActive(false);
            Use2.SetActive(true);
        }
        if (buy3 == true)
        {
            LockSystem3.SetActive(false);
            Buy3.SetActive(false);
            Use3.SetActive(true);
        }
        if (buy4 == true)
        {
            LockSystem4.SetActive(false);
            Buy4.SetActive(false);
            Use4.SetActive(true);
        }
        if (buy5 == true)
        {
            LockSystem5.SetActive(false);
            Buy5.SetActive(false);
            Use5.SetActive(true);
        }
    }

    public void Update()
    {
        moneyText.text = money.ToString();
    }



    public void BuySystem1()
    {
        if (money >= 200)
        {
            buy1 = true;
            LockSystem1.SetActive(false);
            Buy1.SetActive(false);
            Use1.SetActive(true);
            money -= 200;
        }


    }
    public void BuySystem2()
    {
        if (money >= 500)
        {
            buy2 = true;
            LockSystem2.SetActive(false);
            Buy2.SetActive(false);
            Use2.SetActive(true);
            money -= 500;
        }


    }
    public void BuySystem3()
    {
        if (money >= 800)
        {
            buy3 = true;
            LockSystem3.SetActive(false);
            Buy3.SetActive(false);
            Use3.SetActive(true);
            money -= 800;
        }


    }
    public void BuySystem4()
    {
        if (money >= 1000)
        {
            buy4 = true;
            LockSystem4.SetActive(false);
            Buy4.SetActive(false);
            Use4.SetActive(true);
            money -= 1000;
        }


    }
    public void BuySystem5()
    {
        if (money >= 1500)
        {
            buy5 = true;
            LockSystem5.SetActive(false);
            Buy5.SetActive(false);
            Use5.SetActive(true);
            money -= 1500;
        }


    }
}

