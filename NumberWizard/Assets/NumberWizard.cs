using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard.");
        Debug.Log("Pick a number, please. But don't tell me what it is.");
        Debug.Log("I'm going to guess. I'm the Number Wizard.");
        Debug.Log("Highest number you can pick is: " + max + ".");
        Debug.Log("Lowest number you can pick is:" + min + ".");
        Debug.Log("I think your number is " + guess + ".");
        Debug.Log("Tell me if your number is lower or higher than my guess, please.");
        Debug.Log("Up Arrow = Higher / Down Arrow = Lower / Enter = Correct");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Correct();
            Start();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;

        Debug.Log("Is is higher or lower than " + guess + "?");
        Debug.Log("Up Arrow = Higher / Down Arrow = Lower / Enter = Correct")

    }

    void Correct()
    {
        Debug.Log("I knew it.");
        Debug.Log("Your number was " + guess + ".");

    }
}
