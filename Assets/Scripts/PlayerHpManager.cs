﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpManager : MonoBehaviour {

    public float playerMaxHealth;
    public float playerCurrentHealth;
    public float healthBarLength;
    public DeathMenu theDeathScreen;

	// Use this for initialization
	void Start () {
        playerCurrentHealth = playerMaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            theDeathScreen.gameObject.SetActive(true);
        }
	}

    public void DmgPlayer(float damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
