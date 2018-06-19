using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//code allowing gamemanager script to be called from other scripts
	public static GameManager instance;

	//variables to save after loading scenes
	public int drops; //number of times disc has been dropped on current level
	public int check; //used to keep potential score for drop, waiting in case disk bounces into other slot
	public int score; //running score total
	public string scoreText = "Score: 0"; //for displaying score

	private void Awake()
	{
		if (instance == null) {
			DontDestroyOnLoad (gameObject);
			instance = this;
		}
		else if(instance != this){
			Destroy (gameObject);
		}
	}

	//void OnGUI() //displays in top left for trouble shooting if drops and score being counted/saved to GameManager
	//{
		//GUI.Label (new Rect (10, 10, 100, 30), "Drops: " + drops);
		//GUI.Label (new Rect (10, 40, 100, 30), "Score: " + score);
		//GUI.Label (new Rect (10, 70, 100, 30), "Check: " + check);
		//GUI.Label (new Rect (10, 100, 150, 30), "Score Label: " + scoreText);
	//}
}
