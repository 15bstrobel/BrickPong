using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deadzone : MonoBehaviour {

	public List<GameObject> lives;
	public int player;
	public float respawnTime = 2f;

	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.SetActive (false);

		other.GetComponent<Ball1Move> ().Invoke("Respawn", respawnTime);
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
