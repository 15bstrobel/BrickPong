using UnityEngine;
using System.Collections;

public class Ball1Move : MonoBehaviour {

	public float ballVelocity = 200;
	Rigidbody2D rb;
	bool isPlay;
	int randInt;

	void Awake () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		randInt = Random.Range (1, 3);
	}
	

	void Update () {
		if (Input.GetKey(KeyCode.Space) == true && isPlay == false) {
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			if (randInt == 1) {
				rb.AddForce(new Vector3(ballVelocity,0,0));
			}
		if (randInt == 2) {
				rb.AddForce(new Vector3(-ballVelocity,0,0));
			}

		}
	}

	void OnCollisionEnter2D(Collision2D hit) {
		if (hit.gameObject.CompareTag("Player")) {
			Vector3 d = gameObject.transform.position - hit.gameObject.transform.position;
			d.y *= .5f;
			d.Normalize();
			rb.velocity = Vector2.zero;
			rb.AddForce(new Vector2(d.x * ballVelocity, d.y * ballVelocity));
		}
	}


}