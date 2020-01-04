using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovesIndicator : MonoBehaviour
{
    public GameObject MovesText;


    void Update()
    {
        MovesText.GetComponent<Text>().text = "Moves: " + PlayerController.moves;
    }
}
