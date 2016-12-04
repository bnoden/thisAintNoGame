using UnityEngine;
using System.Collections;

public class Spiral : MonoBehaviour {

    public AudioSource spiralFX;
    public Manager manager;
    public Anna anna;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Enemy" || obj.gameObject.tag == "Item") {
            Devour();
            Destroy(obj.gameObject);
        }

        if (anna.getSaved()) {
            if (obj.gameObject.tag == "Player") {
                spiralFX.Play();
                manager.LoadLevel("Intro");
            }
        }

    }

    void Devour() {
        spiralFX.Play();
    }
}
