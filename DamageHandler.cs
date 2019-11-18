using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public int health = 1;

	void Start() {
	}

    void OnMouseDown() {
		Debug.Log ("Boom!");
		health--;
		
	}

	void Update() {

	if(health <=0) {
		Die();
		}

	}
	void Die() {
		Destroy(gameObject);
	}

}