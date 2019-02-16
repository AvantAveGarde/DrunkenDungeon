using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
	public float destroyTime = 5f;
	public float currentTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentTime < destroyTime)
		{
			currentTime += Time.deltaTime;
		}
		else
		{
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		//do something in the player
		if(collision.gameObject.tag != "enemy")
		{
			Destroy(gameObject);
		}
	}
}
