using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // creates 3 variables
    int min = 1;
    int max = 1000;
    int guess = 500;

    void nextguess()
    {
        print("Is the number smaller or greater than" + guess + "?");
        print("Up:Greater DOWN:Smaller ENTER:Equal");
    }

    void startgame()
    {
        // prints once to console
        print("Welcome to numberwizard");
        Debug.Log("Please choose a number between " + min + " and " + max);
        nextguess();
    }

    // Use this for initialization
    void Start () {
        startgame();
	}
	
	// Update is called once per frame
	void Update () {

        // if the input is up arrow 
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            nextguess();
            print("");
        }

        else
		
        // if the input is down arrow
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            nextguess();
            print("");

        }

        else

        // if the input is enter
        if(Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter pressed");
            print("The number is " + guess);
            print("");
        }
	}
}
