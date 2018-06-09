using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
	void Awake()
	{
		GetComponent<TextMesh> ().text = GameManager.instance.scoreText;
	}
}