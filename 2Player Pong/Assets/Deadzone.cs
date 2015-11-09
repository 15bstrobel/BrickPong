using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deadzone : MonoBehaviour {

	public List<GameObject> lives;
	public int player;

	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		if (lives.Count > 1) {
			Destroy (lives [0]);
			lives.Remove (lives [0]);
		} else {
			Manager.OnPlayerLost (player);
		}
	}

	void Update () {
	
	}
}
