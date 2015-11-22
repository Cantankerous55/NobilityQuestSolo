using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public int LevelNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		Application.LoadLevel (LevelNumber);
	}
}
