using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

	public GameObject brick;
	public List<GameObject> powerups;
	public int rows;  //height
	public int columns;  //width
	public Vector2 lowerLeft;
	public Vector2 space;
	
	void Start () {
		for (int i = 0; i < columns; i++) {
			for (int j = 0; j < rows; j++) {
				float x = space.x * i + lowerLeft.x;
				float y = space.y * j + lowerLeft.y;
				float xDif = Mathf.Abs(((columns - 1) / 2f) - i) * 1.5f;
				if (Random.Range(0f,1f) < (1f / (xDif + 1))) {
					Instantiate(powerups[Random.Range(0,powerups.Count)], new Vector3(x, y, 0), Quaternion.identity);
				} else {
					Instantiate (brick, new Vector3(x, y, 0), Quaternion.identity);
				}
			}
		}
	}

	void BuildThis() {
		bool[,] brickLayout = new bool[columns, rows];
		int powerUpCount = 0;
		for (int i = 0; i < brickLayout.GetLength(0); i++) {
			for (int j = 0; j < brickLayout.GetLength(1); j++) {
				float xDif = Mathf.Abs (((columns - 1) / 2f) - i) * 2f;
			//	float yDif = Mathf.Abs (((rows - 1) / 2.0) - j) * .25f;
				float probability = 1f / (xDif + 2);
				if (UnityEngine.Random.Range(0f, 1f) < probability) {
					brickLayout [i, j] = true;
					powerUpCount++;
				}
			}
		}
		for (int i = 0; i < (powerUpCount - powerups.Count); i++) {
		}

				

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
