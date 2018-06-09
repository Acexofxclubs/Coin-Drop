using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public void loadScene(int level){ 

		GameManager.instance.score = 0;
		GameManager.instance.scoreText = "Score: 0"; //returning to start values if player playing game again

		SceneManager.LoadScene(level);
	}
}