using UnityEngine;
using System.Collections;

public class Organ : MonoBehaviour {

    public GameObject organ;
    public Edward edward;
    public Anna anna;
    public TextBox textbox;
    public Content content;

    Color colorAnna;

	// Use this for initialization
	void Start () {
	    colorAnna = anna.GetComponent<SpriteRenderer>().color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Destroyer") {
            edward.Stand();
            content.setText(1);
            content.OpenBox();
            colorAnna.a = 255f;
            Destroy(organ);
        }
    }
}
