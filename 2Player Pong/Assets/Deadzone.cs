using UnityEngine;
using System.Collections;

public class Deadzone : MonoBehaviour {

	public GameObject heart;



	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		Destroy (heart);
	}

	void Update () {
	
	}
}
