using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour {

    private GameManager gameManager = GameManager.instance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //When left clicking the dice, we add money
		if (Input.GetMouseButtonDown(0))
        {
            
        }
	}

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log(gameManager.addMoney(10));
    }
}
