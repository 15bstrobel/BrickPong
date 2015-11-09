using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deadzone : MonoBehaviour {

	public List<GameObject> lives;

	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		Destroy (lives [0]);
		lives.Remove (lives [0]);
	}

	void Update () {
	
	}
}
