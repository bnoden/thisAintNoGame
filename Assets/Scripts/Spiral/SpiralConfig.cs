using UnityEngine;
using System.Collections;

public class SpiralConfig : MonoBehaviour {

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

        if (obj.gameObject.tag == "Player") {
            spiralFX.Play();
            manager.LoadLevel("GameOver");
            }

    }

    void Devour() {
        spiralFX.Play();
    }
}
