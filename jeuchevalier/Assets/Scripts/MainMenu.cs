using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string LvlToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(LvlToLoad);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
