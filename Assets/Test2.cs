using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {
    string jusyo = "gihu";
    void HelloName(string name)
    {
        Debug.Log("kick us!!!"+name+jusyo);
    }
	// Use this for initialization
	void Start () {
        HelloName("aiueo");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
