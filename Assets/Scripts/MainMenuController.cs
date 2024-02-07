using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    void Start()
    {
        // If you have a GameManager handling game states
        // GameManager.Instance.ChangeState(GameState.MainMenu);
    }

    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("GameScene"); // Make sure this matches the name of your game scene
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }

    // Add other menu functionality as needed
}
