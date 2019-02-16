using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    // Use this for initialization
    public Slider healthSlider;
    List<string> inventory = new List<string>();
    int health, maxHealth = 100;
    bool dead;
	void Start ()
    {
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
        healthSlider.value = (float)health / (float)maxHealth;
        if (health <= 0)
        {
            dead = true;
        }
	}
}
