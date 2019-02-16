using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour {

    public int keyCount;
    public int coinCount;
	public int maxHealth = 100;
	public int currentHealth = 100;
    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
        currentHealth = maxHealth;
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth < 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
	public void DealDamage(int amount)
	{
		currentHealth -= amount;
	}
}
