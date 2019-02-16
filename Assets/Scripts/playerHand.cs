using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHand : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E)) {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(transform.position, transform.forward, 10.0F);
            foreach (RaycastHit hit in hits)
            {
                Interaction i = hit.transform.gameObject.GetComponent<Interaction>();
                i.DoSomething();
            }
        }
    }
}
