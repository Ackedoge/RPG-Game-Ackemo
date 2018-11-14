using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemies : MonoBehaviour {

    public float damageToGive;
    public GameObject damageBurst;
    public Transform hitPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    //skapar en collider som påvärkas av andra colliders

    private void OnTriggerEnter2D(Collider2D other)
    {
        //om collidern rör vid ett objekt i unity med taggen "Enemy" körs följande kod
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            //lägger in en funktion till damageToGive variabeln så den kan justeras i unity
            other.gameObject.GetComponent<EnemyHpManager>().DmgEnemy(damageToGive);
            //får fram objectet "damageBurst" som är en indikator för spelaren att den skadat en fiende
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
        }
    }
}
