using UnityEngine;
using System.Collections;

// Initializes player paddles, pauses the game. Set min and max to the lowest and highest paddle
// y values, and pauseKey to the pause button. 

// Call OnPlayerLost(int) when you want to tell the game the player lost.

public class Manager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public float min;
	public float max;
	public KeyCode pauseKey; 

	
	bool pause = false;

	public static Manager current;

	void Awake() {
		current = this;
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		player1.GetComponent<PlayerMove>().setMinMax(min, max);
		player2.GetComponent<PlayerMove>().setMinMax(min, max);
	}
	
	// Update is called once per frame
	void Update () {

		// Pause doesn't work
		if (Input.GetKeyDown(pauseKey)) {
			pause = !pause;
			if (pause) {
				Time.timeScale = 0f;
			} else {
				Time.timeScale = 1f;
			}
		}
	}

	public static void OnPlayerLost(int player) {
		GeneralMessage.setMessage("Player " + player + " lost.");
	}
}
