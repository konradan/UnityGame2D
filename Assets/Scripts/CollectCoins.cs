using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour {

    private Player player;
    public GameObject Sparkle;

    // Use this for initialization
    void Start () {       
           player = FindObjectOfType<Player>();        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.coins++;
            Instantiate(Sparkle, gameObject.transform.position, gameObject.transform.
            rotation);
            Destroy(gameObject);
        }
    }
}
