using UnityEngine;
using UnityEngine.UI;

public class DiscDisplay : MonoBehaviour
{
	private int discs;

	void Awake()
	{
		discs = 2 - GameManager.instance.drops ;
		GetComponent<TextMesh> ().text = ("Discs: " + discs);
	}
}