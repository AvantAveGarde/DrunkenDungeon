using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    //track this object's tag
    private string tag;
    GameObject playerInfo;
    public int storedCoins = 1;
    public int storedKeys = 0;
    public Transform coinPrefab;
    public Transform keyPrefab;

	// Use this for initialization
	void Start () {
        tag = gameObject.tag;
        playerInfo = GameObject.Find("GameManager");
	}


    public void DoSomething() {  
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
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                SpewItems();
                return;
        }
        // delete it
        Destroy(gameObject); 
    }

    private void SpewItems()
    {
        Debug.Log("aaaahh fire!");
        for (int i = 0; i < storedCoins; i++)
        {
            float xVel = Random.value/5 - 1/5;
            float yVel = Random.value/3;
            float zVel = .1f;
            Transform newItem = Object.Instantiate(coinPrefab);
            newItem.position = gameObject.transform.position + new Vector3(0, .3f, 0);
            //newItem.GetComponent<Rigidbody>().velocity = new Vector3(xVel, yVel, zVel);
        }
        for (int i = 0; i < storedKeys; i++)
        {
            float xVel = Random.value * 4 - 2;
            float yVel = Random.value + .5f;
            float zVel = 1f;
            Transform newItem = Object.Instantiate(keyPrefab);
            newItem.position = gameObject.transform.position + new Vector3(0, .3f, 0);
            //newItem.GetComponent<Rigidbody>().velocity = new Vector3(xVel, yVel, zVel);
        }
    }
}
