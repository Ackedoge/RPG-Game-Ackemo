using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;
    private static bool cameraExists;

	// Use this for initialization
	void Start () {
        // if-satsen kontrollerar ifall det finns eller inte finns en kamera kontroll på den nya scenen som laddas in, finns det inte en, tar den inte bort den som "tas med"
        if(!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        } else
        // om en kamera kontroll finns tar den bort den, så det blir aldrig mer än 1.
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    // Kamera kontrollen rör sig på ungefär samma vilkor som player, men hastigheten bestäms i Unity
    void Update () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
