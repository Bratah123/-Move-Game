using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;

    // how many squares the player can move per move

    public float squareMovementHorizontal = 2f;
    public float squareMovementHorizontal2 = -2f;

    // How many squares they move up and down

    public float squareMovementVertical = 2f;
    public float squareMovementVertical2 = -2f;

    // maximum moves the player is allowed

    public static int moves;
    public int internalMoves = 5;
    int originalMoves = 5;

    // puts the player at spawn point and sets amount of moves at 5
    void Start()
    {
        moves = internalMoves;
        player.position = respawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        moves = internalMoves;

        Vector3 playerHorizontal = new Vector3(squareMovementHorizontal, 0f, 0f);
        Vector3 playerHorizontal2 = new Vector3(squareMovementHorizontal2, 0f, 0f);
        Vector3 playerVertical = new Vector3(0f, squareMovementVertical, 0f);
        Vector3 playerVertical2 = new Vector3(0f, squareMovementVertical2, 0f);

        // WASD controls, up, down, left, and right

        // right
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.Translate(playerHorizontal);
            internalMoves--;
        }
        // left
        else if(Input.GetKeyDown(KeyCode.A))
        {
            player.Translate(playerHorizontal2);
            internalMoves--;
        }
        // up
        else if (Input.GetKeyDown(KeyCode.W))
        {
            player.Translate(playerVertical);
            internalMoves--;
        }
        // down
        else if (Input.GetKeyDown(KeyCode.S))
        {
            player.Translate(playerVertical2);
            internalMoves--;
        }

        maxHeightWidth();
        movesLogic();
    }

    // The coordinates that respawns player back to beginning of level

    Vector3 respawnPoint = new Vector3(-8f, -4f, 0f);
    void maxHeightWidth()
    {

        // if they past the boundary move them back to original spot.
        if(transform.position.x > 8)
        {
            player.Translate(-2f, 0f, 0f);
            internalMoves++;
        }
        else if(transform.position.x < -8)
        {
            player.Translate(2f, 0f, 0f);
            internalMoves++;
        }
        else if (transform.position.y > 2)
        {
            player.Translate(0f, -2f, 0f);
            internalMoves++;
        }
        else if (transform.position.y < -4)
        {
            player.Translate(0f, 2f, 0f);
            internalMoves++;
        }
    }

    // if you run out of moves then respawn character
    void movesLogic()
    {
        if(moves <= 0)
        {
            Respawn();
        }
    }

    // resets the position of the player back to the middle and give them 2 more moves (Dying is rewarded)
    void Respawn()
    {
        originalMoves += 2;
        player.position = respawnPoint;

        internalMoves = originalMoves;

    }
}
