using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite three;
	public Sprite two;
	public Sprite one;
	int strength;
	int currentStrength;
	SpriteRenderer s;

	// Use this for initialization
	void Start () {
		s = GetComponent<SpriteRenderer> ();
		strength = Random.Range(1,4);
		currentStrength = strength;
		if (strength == 3) {
			s.sprite = three;
		}
		else if (strength == 2) {
			s.sprite = two;
		}
		else if (strength == 1) {
			s.sprite = one;
		}
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter2D(Collision2D hit) {
		Debug.Log ("collided with ball.");
		
		if (hit.gameObject.CompareTag("Ball")) {
			currentStrength--;
			Debug.Log (currentStrength);
			if (currentStrength <= 0) {
				Destroy(gameObject);
			}
			if (currentStrength == 3) {
				s.sprite = three;
			}
			else if (currentStrength == 2) {
				s.sprite = two;
			}
			else if (currentStrength == 1) {
				s.sprite = one;
			}
		}
	}

}
