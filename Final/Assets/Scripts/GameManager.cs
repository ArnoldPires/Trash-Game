using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GameObject scoreTextObject;

	int score;
	Text scoreText;
	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != null) {
			Destroy (gameObject);
		}
		scoreText = scoreTextObject.GetComponent<Text> ();
		scoreText.text = "Carbon Score \n" + score.ToString ();
	}

	public void Collect(int passValue, GameObject passObject) {
		//Destroy (passObject);
		score = score + passValue;
		scoreText.text = "Carbon Score \n" + score.ToString();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
