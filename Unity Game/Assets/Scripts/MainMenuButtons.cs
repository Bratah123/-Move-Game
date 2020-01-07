using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Loads the scene for all of the Levels
    public Transform player;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Exits application of game
    public void QuitGame()
    {
        Application.Quit();
    }

    public void InfoPage()
    {
        SceneManager.LoadScene("InfoPage");
    }

    // For the back button in InfoPage
    // Probably not a smart idea to create another scene for the info page but whatever lol.
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {

        int originalMoves = 1;

        Vector3 respawnPos = new Vector3(-8f, -4f, 0f);

        player.position = respawnPos;
        

        PlayerController.moves = originalMoves;

    }

}
