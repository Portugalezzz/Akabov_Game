using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Akabov");
    }

    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}