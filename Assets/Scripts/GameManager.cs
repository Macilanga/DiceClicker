using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public Transform dice;

    private int money { get; set; }

	// Use this for initialization
	void Awake () {
		if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        money = 0;

        Instantiate(dice);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Add the value to the current money
    /// </summary>
    /// <param name="value">value to add to the current money</param>
    /// <returns>current money after adding the value</returns>
    public int addMoney(int value)
    {
        return money += value;
    }
}
