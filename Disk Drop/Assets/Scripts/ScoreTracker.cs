using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour {

	// Update is called once per frame
	public void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Points10") {
			GameManager.instance.check = 10;
		}
		if (other.tag == "Points30") {
			GameManager.instance.check = 30;
		}
		if (other.tag == "Points50") {
			GameManager.instance.check = 50;
		}
		if (other.tag == "Points20") {
			GameManager.instance.check = 20;
		}
		if (other.tag == "PointsNeg100") {
			GameManager.instance.check = -100;
		}
	}
}
