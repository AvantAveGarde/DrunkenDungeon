using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

    public int keyCount;
    public int coinCount;
	public int maxHealth = 100;
	public int currentHealth = 100;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DealDamage(int amount)
	{
		currentHealth -= amount;
	}
}
