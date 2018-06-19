using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Platformer2DUserControl : MonoBehaviour
{
	private Rigidbody2D m_Rigidbody2D;
	public float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
	public bool m_AirControl = true;                 // Whether or not a player can steer while jumping;
	public int hits; 				    // used to count number of times disk bounces on ground, to reset level


	private void Start() // adding to initiallize counter to 0 
	{
		hits = 0;
	}
		
    private void Awake()
    {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
		
    private void Update()
    {
		if (m_AirControl == true) {
			Move ();
		}

		if (Input.GetKeyDown (KeyCode.Space))
		{
			m_Rigidbody2D.gravityScale = 2; //disc had gravity of 0, now giving it gravity so it falls after space is pressed to drop it
			m_AirControl = false; //disabling air control that allows for selecting where disk should drop, so user cannot control its fall
		}
    }
		

	void Move()
	{
		if (Input.GetKey ("left")) {
			transform.Translate (-m_MaxSpeed * Time.deltaTime, 0, 0);
		}    

		if (Input.GetKey ("right")) {
			transform.Translate (m_MaxSpeed * Time.deltaTime, 0, 0);
		}
	}
}
