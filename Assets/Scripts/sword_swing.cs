using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_swing : MonoBehaviour {

    public GameObject owner;
    [SerializeField] private float swing_time;
    [SerializeField] private float swing_speed;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        transform.RotateAround(owner.transform.position, transform.up, swing_speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update () {
        swing_time -= Time.deltaTime;
        if(swing_time <= 0)
        {
            Destroy(gameObject);
        }
	}
}
