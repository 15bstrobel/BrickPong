using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Use this to display large messages to the player. All you must do is call
// GeneralMessage.setMessage(text) from any code, since it's static.


public class GeneralMessage : MonoBehaviour {

	static Text display;
	public static void setMessage(string text) {
		display.text = text;
	}



	void Start () {
		display = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
