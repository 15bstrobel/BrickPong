using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float speed;
	public KeyCode up;
	public KeyCode down;

	float min = -5f;
	float max = 5f;
	
	// Use this for initialization
	void Start () {
		
	}

	public void setMinMax(float min, float max) {
		this.min = min;
		this.max = max;
	}

	// To be called when game is ready start
	public void startGame() {

	}


	
	// Update is called once per frame
	void Update () {
		float movement = 0;
		if (Input.GetKey(up)) {
			movement += speed * Time.deltaTime;
		}
		if (Input.GetKey(down)) {
			movement -= speed * Time.deltaTime;
		}
		movement += gameObject.transform.position.y;
		movement = Mathf.Clamp(movement, min, max);
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, movement, 0);
	}
}
