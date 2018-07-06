using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicks : MonoBehaviour {

    // Cash variables
    public long AutoGenerate = 0;
    public int AutoMultiplier = 1;
    public long BaseClickValue = 1;
    public int ClickMultiplier = 1;

    public Image Crop;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Crop.GetComponent<Crops>().Grow(2);
        }
	}
}
