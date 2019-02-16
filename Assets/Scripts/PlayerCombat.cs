using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {
    int damage = 20;
    public BoxCollider collisionBox;
	gameManager Manager; 
    // Use this for initialization
	void Start ()
    {
        collisionBox = GetComponent<BoxCollider>();
        Manager = GameObject.Find("GameManager").GetComponent<gameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (other.tag.Equals("Enemy"))
            {
                GameObject enemy = other.gameObject;
                DealDamage(enemy);
            }
        }
    }

    void DealDamage(GameObject enemy)
    {
        enemy.GetComponent<Enemy>().DealDamage(damage);
    }
}
