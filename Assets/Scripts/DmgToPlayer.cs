using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgToPlayer : MonoBehaviour {

    public float damageToGive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHpManager>().DmgPlayer(damageToGive);
        }
    }
}
