﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public int health = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DealDamage()
	{
		health--;
		if(health == 0)
		{
			//Instantiate an item,
			//then Destroy(this);
		}
	}
}