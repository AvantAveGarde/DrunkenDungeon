using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    //track this object's tag
    private string tag;
    GameObject playerInfo;

	// Use this for initialization
	void Start () {
        tag = gameObject.tag;
        playerInfo = GameObject.Find("GameManager");
	}


    void doSomething() {
        
        switch (tag)
        {
            case "door":
                //open the door
                Debug.Log("hello you bint");
                break;
            case "key":
                // pick up key
                break;
            case "coin":
                //pick up coin
                break;
            case "chest":
                //open chest
                break;
        }
        // delete it
        Destroy(gameObject); 
    }
}
