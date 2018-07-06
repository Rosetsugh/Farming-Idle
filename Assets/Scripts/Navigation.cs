using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {

    public Button StartButton;
    public Button OptionsButton;
    public Button ExitButton;

	// Use this for initialization
	void Start ()
    {
        StartButton.onClick.AddListener(StartClick);
        OptionsButton.onClick.AddListener(OptionsClick);
        ExitButton.onClick.AddListener(ExitClick);
	}
	
    void StartClick ()
    {
        SceneManager.LoadScene("Game"); 
    }  

    void OptionsClick ()
    {
        Debug.Log("Options");
    }

    void ExitClick ()
    {
        Debug.Log("Exit");
    }
}
