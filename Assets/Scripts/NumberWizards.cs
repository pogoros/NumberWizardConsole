using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	// Start Function
	void Start () {
	
		StartGame();	
		
		}

	void StartGame(){
		
		max = 1000;
		min = 1;
		guess = 500;
		
		
		
		print("==========================");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head and don't tell me.");
		
		print("The highest number you may choose is " + max + ".");
		print("The lowest number you may choose is " + min + ".");
		print("Is the Number Higher or Lower than " + guess + "?");
		print("Press Up Arrow for Higher, Down Arrow for Lower, or Return for =");
		
		max=max+1;
	}
	
	// Update is called once per frame
	// Update Function
	void Update () {
		//GetKeyDown denotes a key that is pressed
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up arrow was pressed");
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow was pressed");
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)){
			print("I won!");
			StartGame();
		}
	}
	
	void NextGuess() {
		guess = (max+min)/2;
		print ("Is the guess higher or lower than " + guess + "?");
		print ("Press Up Arrow for Higher, Down Arrow for Lower, or Return for =");
		
	}
	
}
