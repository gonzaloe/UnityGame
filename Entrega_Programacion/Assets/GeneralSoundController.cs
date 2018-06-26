using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSoundController : MonoBehaviour {

    AudioListener audioListener;
    public Text text;

	// Use this for initialization
	void Start () {
    }

    public void OffSound () {
        audioListener = Camera.main.GetComponent<AudioListener>();
        audioListener.enabled = false;
	}

    public void ChangeSound()
    {
        audioListener = Camera.main.GetComponent<AudioListener>();
        audioListener.enabled = !audioListener.enabled;
        if(audioListener.enabled)
        {
            text.text = "ON";
        } else
        {
            text.text = "OFF";
        }
    }
}
