using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			//resets level if ball has bounced 3 times on ground
			GameObject.Find("Player").GetComponent<Platformer2DUserControl>().hits += 1;
			if (GameObject.Find ("Player").GetComponent<Platformer2DUserControl> ().hits == 3) {
				GameManager.instance.drops += 1; //adding 1 to count of number of discs dropped

				//deciding what points to add to score
				if (GameManager.instance.check == 10){
					GameManager.instance.score += 10;
				}
				if (GameManager.instance.check == 30){
					GameManager.instance.score += 30;
				}
				if (GameManager.instance.check == 50){
					GameManager.instance.score += 50;
				}
					
				GameManager.instance.scoreText = ("Score: " + GameManager.instance.score.ToString ());

				if (GameManager.instance.drops == 3) {
					GameManager.instance.drops = 0; //setting back to 0 for next stage
					int scene = SceneManager.GetActiveScene ().buildIndex; //index of current scene
					scene += 1; // adding 1 to load next stage
					if (scene == 4) { //checking if going to end game screen, will need to increase index if more stages added
						GameManager.instance.scoreText = ("Final Score: " + GameManager.instance.score.ToString ());
						SceneManager.LoadScene (scene); // loading next stage
					} else {
						SceneManager.LoadScene (scene); // loading next stage
					}
				}else {
					SceneManager.LoadScene (SceneManager.GetSceneAt (0).name);
				}
			}
        }
    }
}

