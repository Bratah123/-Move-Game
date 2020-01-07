using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    public void Death()
    {
        Vector3 respawnCoord = new Vector3(-8f, -4f, 0f);
        PlayerController.moves += 3;
        player.transform.position = respawnCoord;
    }
}
