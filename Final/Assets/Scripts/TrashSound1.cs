using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSound1 : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
		
	}

    void playsound()
    {
        this.GetComponent<AudioSource>().Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        playsound();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
