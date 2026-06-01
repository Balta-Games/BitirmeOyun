using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject restartMenu;
    public GameObject nextStageMenu;
    public GameObject winMenu;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        int menuState = SceneFlow.getMenuState();
        activateSelectedMenu(menuState);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenMainMenu()
    {
        activateSelectedMenu(0);
    }

    private void activateSelectedMenu(int menuState)
    {
        startMenu.SetActive(menuState == 0);
        restartMenu.SetActive(menuState == 1);
        nextStageMenu.SetActive(menuState == 2);
        winMenu.SetActive(menuState == 3);
    }
}
