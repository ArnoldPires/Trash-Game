using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashBinScore : MonoBehaviour {

	public int Value;

	// Use this for initialization
	void Awake () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter() {
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
		GameManager.instance.Collect (Value, gameObject);
	}
}
