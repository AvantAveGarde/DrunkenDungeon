using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_swing : MonoBehaviour {

    public GameObject owner;
    [SerializeField] private float swing_time;
    [SerializeField] private float swing_speed;
    [SerializeField] private int damage;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        transform.RotateAround(owner.transform.position, transform.up * -1, swing_speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update () {
        swing_time -= Time.deltaTime;
        if(swing_time <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject player = other.gameObject.transform.parent.gameObject;
            Player player_comp = player.GetComponent<Player>();
            player_comp.DealDamage(damage);
        }
    }
}
