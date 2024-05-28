using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public bool Volume;

    private void Start()
    {
        Volume = true;
    }

    public void StartRun()
    {
        SceneManager.LoadScene(0);
    }


    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Произведён выход из игры");
    }

    public void VolumeOnOff()
    {
        if (!Volume)
        {
            AudioListener.volume = 1f;
            Volume = true;
        }else if (Volume)
        {
            AudioListener.volume = 0f;
            Volume = false;
        }



    }
}

