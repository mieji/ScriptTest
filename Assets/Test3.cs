using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour {

    int Add(int a,int b)
    {
        int c = a + b;
        return c;
    }
	// Use this for initialization
	void Start () {
        int kekka = Add(10, 50);
        Debug.Log(kekka);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
