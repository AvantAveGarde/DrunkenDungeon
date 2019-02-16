using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Melee_AI : Enemy {
    [SerializeField] private GameObject weapon;
    [SerializeField] private float attack_cd = 1.2f;
    [SerializeField] private float attack_dist = 1.8f;

    private GameObject player;
    private Transform target;
    private NavMeshAgent agent;
    private float cur_cd;

	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null)
        {
            target = player.transform;
            if (agent.enabled)
            {
                agent.destination = target.position;
            }
            if(Vector3.Distance(transform.position, target.position) < attack_dist)
            {
                agent.destination = transform.position;
                if(cur_cd <= 0)
                {
                    cur_cd = attack_cd;
                    Attack();
                }
            }
        }
        if(cur_cd > 0)
        {
            cur_cd -= Time.deltaTime;
        }
	}

    private void Attack()
    {
        GameObject newWeap = Instantiate(weapon, transform);
        newWeap.transform.localPosition = new Vector3(-1.2f, 0, .3f);
        newWeap.GetComponent<sword_swing>().owner = gameObject;
    }
}
