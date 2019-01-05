﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    Text coins;
    private Player player;
    // Use this for initialization
    void Start () {
        coins = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        coins.text = "Coins: " + player.coins;
    }
}
