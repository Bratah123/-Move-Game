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

    public int moves;
    void Start()
    {
       
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
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.Translate(playerHorizontal);
        }
        // left
        else if(Input.GetKeyDown(KeyCode.A))
        {
            player.Translate(playerHorizontal2);
        }
        // up
        else if (Input.GetKeyDown(KeyCode.W))
        {
            player.Translate(playerVertical);
        }
        // down
        else if (Input.GetKeyDown(KeyCode.S))
        {
            player.Translate(playerVertical2);
        }

        maxHeightWidth();
    }

    Vector3 maxPos = new Vector3(0f, 0f, 0f);
    void maxHeightWidth()
    {
        if(transform.position.x > 8)
        {
            player.position = maxPos;
        }
    }
}
