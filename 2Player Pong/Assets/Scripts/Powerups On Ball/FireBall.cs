using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
		gameObject.GetComponent<Collider2D> ().isTrigger = true;
		Invoke ("EndPowerUp", 3f);
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D hit) {
		if (hit.gameObject.CompareTag ("Brick")) {
			Destroy (hit.gameObject);
		}
		if (hit.gameObject.CompareTag ("Wall")) {
			Vector2 v = gameObject.GetComponent<Rigidbody2D>().velocity;
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(v.x, -v.y);
		}
		if (hit.gameObject.CompareTag("Player")) {
			gameObject.GetComponent<Ball1Move>().HitPlayer(hit.gameObject);
		}
	}

	void EndPowerUp() {
		Destroy (this);
	}
	void OnDestroy() {
		gameObject.GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1);
		gameObject.GetComponent<Collider2D> ().isTrigger = false;
	}
}
