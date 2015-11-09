using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public float min;
	public float max;
	public KeyCode pauseKey; 

	bool pause = false;

	// Use this for initialization
	void Start () {
		player1.GetComponent<PlayerMove>().setMinMax(min, max);
		player2.GetComponent<PlayerMove>().setMinMax(min, max);
	}
	
	// Update is called once per frame
	void Update () {

		// Pause doesn't work
		if (Input.GetKey(pauseKey)) {
			pause = !pause;
			if (pause) {
				Time.timeScale = 0f;
			} else {
				Time.timeScale = 1f;
			}
		}

	}
}
