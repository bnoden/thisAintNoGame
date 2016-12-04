using UnityEngine;
using System.Collections;

public class Nu : MonoBehaviour {

    public Vector3 nuPos;
    public GameObject nu;
    public float offset = 0.005f;
    public GameObject player;
    public int hp = 3;

    Color color;

	// Use this for initialization
	void Start () {
        nuPos = transform.position;
        color = nu.GetComponent<SpriteRenderer>().color;
	}
	
	// Update is called once per frame
	void Update () {
	    nuWave();
        
	}

    void nuWave() {
        nuPos += Vector3.up*offset;
        transform.position = nuPos;
        nu.GetComponent<SpriteRenderer>().color = color;
    }
    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.gameObject.tag == "Harp") {
            color.a+=0.08f;
            Destroy(nu);
            Destroy(obj.gameObject);
        }
        if (obj.gameObject.tag == "Player") {

            hp--;
            if (hp == 2) {
                color.g = 0.0f;
            }
            if (hp == 1) {
                color.b = 0.0f;
            }
            if (hp == 0) {
                color.r = 0.0f;
            }
            
        }

    }
    




}
