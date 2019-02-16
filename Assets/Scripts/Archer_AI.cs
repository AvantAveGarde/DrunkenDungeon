using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Archer_AI :Enemy {

	private GameObject player;
	public Transform target;
	private NavMeshAgent agent;
	[SerializeField] private GameObject weapon;
	[SerializeField] public float attack_dist = 12f;
	[SerializeField] public float attack_cooldown = 1f;
	private float cur_cooldown;
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
				agent.destination = transform.position;
				if(cur_cooldown <= 0f)
				{
					cur_cooldown = attack_cooldown;
					transform.LookAt(player.transform);
					Attack();
				}
			}
		}
		if(cur_cooldown > 0f)
		{
			cur_cooldown -= Time.deltaTime;
		}
	}
	private void Attack()
	{
		Vector3 attackPoint = transform.TransformPoint(0,0,1);
		GameObject newWeapon = Instantiate(weapon, attackPoint, transform.rotation * Quaternion.Euler(90f,0f,0f));
		//newWeapon.transform.rotation = transform.rotation;
		//newWeapon.transform.LookAt(player.transform.position);
		newWeapon.transform.localPosition = transform.localPosition + Vector3.Normalize(transform.forward) * 2;
		newWeapon.GetComponent<Rigidbody>().velocity = transform.forward * 4f;
	}
}
