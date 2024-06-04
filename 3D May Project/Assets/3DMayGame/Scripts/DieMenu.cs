using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(1);
    }

}
