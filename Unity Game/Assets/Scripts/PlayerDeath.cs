using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform player;
    public Transform Lava;
    int originalMoves = 1;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Lava")
        {
            Death();
        }
        else if(collision.tag == "FinishLine")
        {
            NextLevel();
        }
    }

    public void Death()
    {
        Vector3 respawnCoord = new Vector3(-8f, -4f, 0f);
        PlayerController.moves += 3;
        player.transform.position = respawnCoord;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
