using UnityEngine;
using System.Collections;

public class FireComet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.CompareTag("Ball")) {
			Destroy(gameObject);
			hit.gameObject.AddComponent<FireBall>();
		}
	}
}
