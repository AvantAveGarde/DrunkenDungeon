using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {
    int damage = 20;
    public BoxCollider collisionBox;
	// Use this for initialization
	void Start ()
    {
        collisionBox = GetComponent<BoxCollider>();
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
        Destroy(enemy);
    }
}
