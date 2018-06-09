using UnityEngine;
using System.Collections;

public class BounceNoise : MonoBehaviour {
	private Animator animator;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.gameObject.tag == "Pin")
		{
			GetComponent<AudioSource> ().Play ();
			animator.SetTrigger ("playerHit");

		}
	}

}
