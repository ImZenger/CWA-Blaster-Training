﻿using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public int health = 1;

	public float invulnPeriod = 0;
	float invulnTimer = 0;
	int correctLayer;

	void Start() {
		correctLayer = gameObject.layer;
	}

    void OnTriggerEnter2D() {
		Debug.Log ("Trigger!");

		SoundManagerScript.PlaySound ("playerhurt");
		health--;
		invulnTimer = invulnPeriod;

		gameObject.layer = 10;

	}

	void Update() {
	
		invulnTimer -= Time.deltaTime;
		if(invulnTimer <= 0) {
			gameObject.layer = correctLayer;
		}

	if(health <=0) {
		Die();
		SoundManagerScript.PlaySound ("ExplosionPlayer");
		}

	}
	void Die() {
		Destroy(gameObject);
	}

}