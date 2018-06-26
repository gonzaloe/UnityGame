using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public Canvas canvas;

    // Use this for initialization
    void Start () {
		
	}

	public void StartGame () {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
	}

    public void SetCredits()
    {
        canvas.enabled = true;
    }

    public void CloseCredits()
    {
        canvas.enabled = false;
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
