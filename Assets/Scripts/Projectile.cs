﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


	public float moveSpeed = 20f;

	public float maxX = 50f;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
		transform.Translate( -moveSpeed*Time.deltaTime , 0, 0);
		if (transform.position.x > maxX || transform.position.x < -maxX) {
			Destroy(gameObject);

		}
	}


	void OnCollisionEnter2D(Collision2D poopcolission) {
		Destroy(gameObject);

        GameManager.instance.Score();
	}
}
