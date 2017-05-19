using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // 1
    private SteamVR_TrackedObject trackedObj;

    // 2
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update () {
        // 1
        if (Controller.GetAxis() != Vector2.zero)
        {

        }

        // 2
        if (Controller.GetHairTriggerDown())
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }

        // 3
        if (Controller.GetHairTriggerUp())
        {
        }

        // 4
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
        }

        // 5
        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
        }
    }
}
