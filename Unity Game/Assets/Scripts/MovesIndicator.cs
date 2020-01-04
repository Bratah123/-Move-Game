using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovesIndicator : MonoBehaviour
{
    public GameObject MovesText;

    // Scripts displays the amount of Moves the Player has
    void Update()
    {
        MovesText.GetComponent<Text>().text = "Moves: " + PlayerController.moves;
    }
}
