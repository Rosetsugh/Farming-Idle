using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crops : MonoBehaviour {

    public int GrowthStages = 20;
    public Sprite[] Stages;
    private int CurrentStage = 0;
    private bool Grown = false;

    private Image DisplayImage;

	// Use this for initialization
	void Start () {
        DisplayImage = gameObject.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Grow (int AddedStages)
    {
        if (Grown)
        {
            CurrentStage = 0;
            Grown = false;
            DisplayImage.sprite = Stages[0];
        } 
        else
        {
            CurrentStage += AddedStages;

            if (CurrentStage >= 20)
            {
                Grown = true;
                DisplayImage.sprite = Stages[Stages.Length - 1];
            }
            else
            {
                DisplayImage.sprite = Stages[CurrentStage / Stages.Length];
            }
        }
    }
}
