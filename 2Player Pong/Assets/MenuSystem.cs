using UnityEngine;
using System.Collections;

// This class sets up a simple GUI interface.

public class MenuSystem : MonoBehaviour {
	
	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update() {
	
	}

	void StartGame() {
		Application.LoadLevel("GenericLevel");
	}
}
