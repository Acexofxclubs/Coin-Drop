using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
		private Rigidbody2D m_Rigidbody2D;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
			if (Input.GetKeyDown (KeyCode.Space))
			{
				m_Rigidbody2D.gravityScale = 2; //disc had gravity of 0, now giving it gravity so it falls after space is pressed to drop it
				m_Character.m_AirControl = false; //disabling air control that allows for selecting where disk should drop, so user cannot control its fall
			}
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
