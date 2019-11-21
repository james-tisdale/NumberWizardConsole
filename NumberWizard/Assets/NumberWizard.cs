using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxGuess = 2000;
        int minGuess = 1;

        Debug.Log("Welcome to Number Wizard."); 
        Debug.Log("Pick a number, please. But don't tell me what it is.");
        Debug.Log("Highest number you can pick is: " + maxGuess + ".");
        Debug.Log("Lowest number you can pick is:" + minGuess + ".");
        Debug.Log("Tell me if your number is lower or higher than my guess, please.");
        Debug.Log("Up Arrow = Higher / Down Arrow = Lower / Enter = Correct");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }


    }
}
