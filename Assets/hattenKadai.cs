using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossN
{
    int mp = 53;

    public void Magic()
    {
        this.mp -= 5;
        if (mp <= 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            Debug.Log("魔法攻撃をした。残りMPは " + mp);
        }
    }
}

public class hattenKadai : MonoBehaviour {

	// Use this for initialization
	void Start () {

        BossN boss = new BossN();
        for (int i = 0; i < 11;i++)
            {
                boss.Magic();
            }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}