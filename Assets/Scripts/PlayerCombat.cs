using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {
    int damage = 20;
    public float maxAttackCoolDownTime = .5f;
    public float attackCooldownTimer;
    private bool attacked = false;
    public BoxCollider collisionBox;
	gameManager Manager; 
    // Use this for initialization
	void Start ()
    {
        collisionBox = GetComponent<BoxCollider>();
        Manager = GameObject.Find("GameManager").GetComponent<gameManager>();
        attackCooldownTimer = maxAttackCoolDownTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (attacked)
        {
            attackCooldownTimer -= Time.deltaTime;
        }
        if(attackCooldownTimer < 0){
            attacked = false;
            attackCooldownTimer = maxAttackCoolDownTime;
        }
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
        if (!attacked)
        {
            enemy.GetComponent<Enemy>().DealDamage(damage);
            attacked = true;
        }
    }
}
