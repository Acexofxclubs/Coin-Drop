using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStop : MonoBehaviour {

	AudioSource audioSource; //will use to kill music when player moves disc

	public float delay = 1f; //for delay of 1sec so player sees level number and score
	public float followNow; //for deciding when to follow

	// Use this for initialization
	void Start () {
		followNow = Time.time + delay; //deciding time stamp for when to follow up to player disc, minimum time before user should move self and kill music
		audioSource = GetComponent<AudioSource>(); //getting audio source component
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > followNow) { //runs camera behavior if delay has occured
			if (Input.GetKeyDown (KeyCode.Space)) {
				audioSource.Stop (); //killing the music
			}
		}
	}
}
