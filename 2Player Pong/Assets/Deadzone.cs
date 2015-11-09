using UnityEngine;
using System.Collections;

public class Deadzone : MonoBehaviour {
	
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
	}

	void Update () {
	
	}
}
