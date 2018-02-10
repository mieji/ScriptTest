using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power= 25;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
        Debug.Log("現在の体力は　" + hp);
    }
}
public class TestClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss lastBoss = new Boss();

        lastBoss.Attack();
        lastBoss.Defence(20);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
