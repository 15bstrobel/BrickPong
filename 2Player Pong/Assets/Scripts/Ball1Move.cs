using UnityEngine;
using System.Collections;

// Bounes around. Will richocet off of player paddle based on the difference in y values.
// Change ballVelocity for the general speed, and yReductionFactor changes how much the 
// difference in Y values affects the ball's changed velocity.

public class Ball1Move : MonoBehaviour {

	Vector3 spawn;
	public float ballVelocity = 200;
	public bool reverse;
	public float yReductonFactor = .5f;
	Rigidbody2D rb;
	bool isPlay;


	void Awake () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Start() {
		spawn = gameObject.transform.position;
	}

	void Update () {
		if (Input.GetKey(KeyCode.Space) == true && isPlay == false) {
			StartMoving();
		}
		//here we need to constantly poll for the direction and reset velocity to ballVelocity in that direction. This 
		//should prevent collisions causing the ball to suddenly stop.
	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.CompareTag("Player")) {
			Vector3 d = gameObject.transform.position - hit.gameObject.transform.position;
			d.y *= yReductonFactor;
			d.Normalize();
			rb.velocity = Vector2.zero;
			rb.AddForce(new Vector2(d.x * ballVelocity, d.y * ballVelocity));
		}
	}

	public void Respawn() {
		gameObject.SetActive(true);
		gameObject.transform.position = spawn;
		StartMoving();
	}

	void StartMoving() {
		transform.parent = null;
		isPlay = true;
		rb.isKinematic = false;
		
		if (!reverse) {
			rb.AddForce(new Vector3(ballVelocity,0,0));
		} else {
			rb.AddForce(new Vector3(-ballVelocity,0,0));
		}
	}
}