using UnityEngine;
using System.Collections;

public class Cactuar : MonoBehaviour {

    public GameObject cactuar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Destroyer") {
            Destroy(cactuar);
        }
    }




}
