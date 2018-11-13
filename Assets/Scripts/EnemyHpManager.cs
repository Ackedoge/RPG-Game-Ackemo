using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpManager : MonoBehaviour {

    public float enemyMaxHealth;
    public float enemyCurrentHealth;

    // Use this for initialization
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }

    public void DmgEnemy(float damageToGive)
    {
        enemyCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }
}
