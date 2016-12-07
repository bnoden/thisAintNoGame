using UnityEngine;
using System.Collections;

public class Cactuar : MonoBehaviour {

    public GameObject cactuar;
    public GameObject player;
    public GameObject spiral;
    Vector3 cacPos;
    Vector3 playerPos;

	// Use this for initialization
	void Start () {
	    cacPos = transform.position;
        playerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position = cacPos;
	}

    void OnCollisionEnter2D(Collision2D obj) {
        if (player) {
            cacPos = Vector3.MoveTowards(cacPos, spiral.transform.position, 1.0f);
        }
        if (obj.gameObject.tag == "Destroyer") {
            Destroy(cactuar);
        }
    }



}


