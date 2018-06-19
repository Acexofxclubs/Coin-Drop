﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackandForth : MonoBehaviour {

	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 3.0f; 
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = startPos;
		v.x += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}
