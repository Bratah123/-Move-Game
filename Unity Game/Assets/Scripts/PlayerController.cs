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
    int originalMoves = 1;

    // checks if the player has any moves left, if it is false they cannot make a move
    bool hasMoves;
    void Start()
    {
        moves = 1;
        player.position = respawnPoint;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerHorizontal = new Vector3(squareMovementHorizontal, 0f, 0f);
        Vector3 playerHorizontal2 = new Vector3(squareMovementHorizontal2, 0f, 0f);
        Vector3 playerVertical = new Vector3(0f, squareMovementVertical, 0f);
        Vector3 playerVertical2 = new Vector3(0f, squareMovementVertical2, 0f);

        // WASD controls, up, down, left, and right

        // right
        if (Input.GetKeyDown(KeyCode.D) && hasMoves == true)
        {
            player.Translate(playerHorizontal);
            PlayerController.moves--;
        }
        // left
        else if(Input.GetKeyDown(KeyCode.A) && hasMoves == true)
        {
            player.Translate(playerHorizontal2);
            PlayerController.moves--;
        }
        // up
        else if (Input.GetKeyDown(KeyCode.W) && hasMoves == true)
        {
            player.Translate(playerVertical);
            PlayerController.moves--;
        }
        // down
        else if (Input.GetKeyDown(KeyCode.S) && hasMoves == true)
        {
            player.Translate(playerVertical2);
            PlayerController.moves--;
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
            PlayerController.moves++;
        }
        else if(transform.position.x < -8)
        {
            player.Translate(2f, 0f, 0f);
            PlayerController.moves++;
        }
        else if (transform.position.y > 2)
        {
            player.Translate(0f, -2f, 0f);
            PlayerController.moves++;
        }
        else if (transform.position.y < -4)
        {
            player.Translate(0f, 2f, 0f);
            PlayerController.moves++;
        }
    }

    // if you run out of moves then respawn character
    void movesLogic()
    {
        if(moves <= 0)
        {
            hasMoves = false;
        }
        else
        {
            hasMoves = true;
        }
    }

    // resets the position of the player back to the middle and give them 2 more moves (Dying is rewarded)
    public void Restart(float i, float j, float k)
    {
        Vector3 respawnPos = new Vector3(i, j, k);

        player.position = respawnPos;

        PlayerController.moves = 1;

    }

}
