using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    public GameObject gameManager;

	// Use this for initialization
	void Awake () {
        //If the GameManager is not already instantiated
		if (GameManager.instance == null)
        {
            //Instantiate the GameManager
            Instantiate(gameManager);
        }
	}
}
