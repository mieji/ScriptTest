using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai01 : MonoBehaviour {

 

    // Use this for initialization
    void Start () {
        int[] money = { 1, 5, 10, 50, 100 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(money[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(money[i]);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
