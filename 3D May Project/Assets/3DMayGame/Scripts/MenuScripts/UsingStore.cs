using UnityEngine;

public class UsingStore : MonoBehaviour
{
    [SerializeField] GameObject Use1;
    [SerializeField] GameObject Using1;
    [SerializeField] GameObject Use2;
    [SerializeField] GameObject Using2;
    [SerializeField] GameObject Use3;
    [SerializeField] GameObject Using3;
    [SerializeField] GameObject Use4;
    [SerializeField] GameObject Using4;
    [SerializeField] GameObject Use5;
    [SerializeField] GameObject Using5;
    public bool acs1;
    public bool acs2;
    public bool acs3;
    public bool acs4;
    public bool acs5;
    public void UseAcs1()
    {
        acs1 = true;
        Use1.SetActive(false);
        Use5.SetActive(true);
        Use2.SetActive(true);
        Use3.SetActive(true);
        Use4.SetActive(true);
        Using1.SetActive(true);
        Using2.SetActive(false);
        Using3.SetActive(false);
        Using4.SetActive(false);
        Using5.SetActive(false);
        acs2 = false;
        acs3 = false;
        acs4 = false;
        acs5 = false;

    }
    public void UseAcs2()
    {
        acs2 = true;
        Use2.SetActive(false);
        Use1.SetActive(true);
        Use5.SetActive(true);
        Use3.SetActive(true);
        Use4.SetActive(true);
        Using2.SetActive(true);
        Using1.SetActive(false);
        Using3.SetActive(false);
        Using4.SetActive(false);
        Using5.SetActive(false);
        acs1 = false;
        acs3 = false;
        acs4 = false;
        acs5 = false;
    }
    public void UseAcs3()
    {
        acs3 = true;
        Use3.SetActive(false);
        Use1.SetActive(true);
        Use2.SetActive(true);
        Use5.SetActive(true);
        Use4.SetActive(true);
        Using3.SetActive(true);
        Using1.SetActive(false);
        Using2.SetActive(false);
        Using4.SetActive(false);
        Using5.SetActive(false);
        acs2 = false;
        acs1 = false;
        acs4 = false;
        acs5 = false;
    }
    public void UseAcs4()
    {
        acs4 = true;
        Use4.SetActive(false);
        Use1.SetActive(true);
        Use2.SetActive(true);
        Use3.SetActive(true);
        Use5.SetActive(true);
        Using4.SetActive(true);
        Using1.SetActive(false);
        Using2.SetActive(false);
        Using3.SetActive(false);
        Using5.SetActive(false);
        acs2 = false;
        acs3 = false;
        acs1 = false;
        acs5 = false;
    }
    public void UseAcs5()
    {
        acs5 = true;
        Use5.SetActive(false);
        Use1.SetActive(true);
        Use2.SetActive(true);
        Use3.SetActive(true);
        Use4.SetActive(true);
        Using5.SetActive(true);
        Using1.SetActive(false);
        Using2.SetActive(false);
        Using3.SetActive(false);
        Using4.SetActive(false);
        acs2 = false;
        acs3 = false;
        acs4 = false;
        acs1 = false;
    }

}
