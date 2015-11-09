using UnityEngine;
using System.Collections;

public class Ball1Move : MonoBehaviour {

	public float ballVelocity = 3000;
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
				rb.AddForce(new Vector3(ballVelocity,ballVelocity,0));
			}
			if (randInt == 2) {
				rb.AddForce(new Vector3(-ballVelocity,-ballVelocity,0));
			}

		}
	}
}