using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    // Use this for initialization
    public gameManager manager;
    bool dead = false;
	void Start ()
    {
        manager = GameObject.Find("GameManager").GetComponent<gameManager>();

	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void DealDamage(int amt)
    {
        manager.DealDamage(amt);
    }
}
