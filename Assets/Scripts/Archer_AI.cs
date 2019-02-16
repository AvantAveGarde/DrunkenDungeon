using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Archer_AI : MonoBehaviour {

	private GameObject player;
	public Transform target;
	private NavMeshAgent agent;
	[SerializeField] private GameObject weapon;
	[SerializeField] private float attack_dist;
	private float cur_coold;
	// Use this for initialization
	void Start () {
		
	}
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		agent = this.GetComponent<NavMeshAgent>();
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
				agent.enabled = false;
			}
			else
			{
				agent.enabled = true;
			}
		}
	}
	private void Attack()
	{
		GameObject newWeapon = Instantiate(weapon, transform);
		newWeapon.transform.localPosition = transform.position + transform.forward;
	}
}
