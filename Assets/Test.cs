using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = { 10, 20, 80, 90, 100 };


        for (int i = 0; i < 5; i++)
        {
            
            if (points[i] > 50)
            {
                
                Debug.Log(points[i]);
            }

        }
    }

	// Update is called once per frame
	void Update () {

	}
}
