using System;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int iMax;
    int iMin;
    int iGuess;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // print("up arrow key was pressed");
            iMin = iGuess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // print("down arrow key pressed");
            iMax = iGuess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            
            StartGame();
        }
    }

    void StartGame()
    {
        iMax = 1000;
        iMin = 1;
        iGuess = 500;

        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me");

        print("The highest number you can pick is " + iMax);
        print("The lowest number you can pick is " + iMin);

        print("Is the number higher or lower than " + iGuess + "?");
        print("Press UpArrow if higher, DownArrow if lower, Enter if equal");
        iMax++;
    }

    void NextGuess()
    {
        iGuess = (iMax + iMin) / 2;
        print("Higher or lower than " + iGuess);
        print("Press UpArrow if higher, DownArrow if lower, Enter if equal");
    }
}