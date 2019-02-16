using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Interaction : MonoBehaviour {

    //track this object's tag
    private string tag;
    public int storedCoins = 1;
    public int storedKeys = 0;
    public Transform coinPrefab;
    public Transform keyPrefab;
    private gameManager gm;

	// Use this for initialization
	void Start () {
        tag = gameObject.tag;
        gm = GameObject.Find("GameManager").GetComponent<gameManager>(); ;
	}


    public void DoSomething() {  
        switch (tag)
        {
            case "door":
                //open the door
                if (gm.keyCount > 0)
                {
                    gm.keyCount--;
                    Destroy(gameObject);
                }
                
                break;
            case "key":
                // pick up key
                gm.keyCount++;
                Destroy(gameObject);
                break;
            case "coin":
                //pick up coin
                gm.coinCount++;
                Destroy(gameObject);
                break;
            case "chest":
                //open chest
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                SpewItems();
                return;
            case "LevelLoader":
                SceneManager.LoadScene("Level2Master");
                break;
            case "FinalLoader":
                SceneManager.LoadScene("FinalLevel");
                break;
        }
        
    }

    private void SpewItems()
    {
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
