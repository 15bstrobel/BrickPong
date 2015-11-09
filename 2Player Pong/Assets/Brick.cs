using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int strength;
	int currentStrength;

	// Use this for initialization
	void Start () {
		currentStrength = strength;
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.CompareTag("Ball")) {
			currentStrength--;
			if (currentStrength <= 0) {
				Destroy(gameObject);
			}
		}
	}

}
