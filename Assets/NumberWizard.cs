using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard");
        
        Debug.Log($"Pick a number between {min} and {max}");

        max = max + 1;

        CalculateGuess();

        Debug.Log("Higher = Up Arrow. Lower = Down Arrow. Exact = Enter.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            CalculateGuess();

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            CalculateGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice!");
            ResetGame();
        }

    }

    void CalculateGuess()
    {
        guess = ( min + max ) / 2;

        Debug.Log($"Is you number higher or lower than {guess}?");
    }

    void ResetGame()
    {
        Debug.Log("Resetting game");
        min = 1;
        max = 1000;

        Start();
    }
}
