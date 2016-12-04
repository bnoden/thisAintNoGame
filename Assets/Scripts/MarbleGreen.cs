using UnityEngine;
using System.Collections;

public class MarbleGreen : MonoBehaviour {

    public GameObject boss;
    public Anna anna;
    public AudioSource marbleHitFX;
    public GameObject harp;

    public int hp = 100;
    public float alphaStep;

    Color bossColor;
    Color annaColor;

	// Use this for initialization
	void Start () {
        bossColor = boss.GetComponent<SpriteRenderer>().color;
        annaColor = anna.GetComponent<SpriteRenderer>().color;
	}
	
	// Update is called once per frame
	void Update () {
	    marbleHit();
        
	}

    void marbleHit() {
        boss.GetComponent<SpriteRenderer>().color = bossColor;
        anna.GetComponent<SpriteRenderer>().color = annaColor;
        
    }
    void OnTriggerEnter2D(Collider2D obj) {
        
        if (harp.transform.localScale.x < 16.0f) {Debug.Log(harp.transform.localScale.x); alphaStep = 0.027f; }
        if (this.harp.transform.localScale.x >= 16.0f) {Debug.Log("It's a big one!"); alphaStep = 0.6f; }

        if (bossColor.a > 0.0f) {
            if (obj.gameObject.tag == "Harp") {
                bossColor.a-=alphaStep;
                annaColor.a+=alphaStep*0.4f;
                marbleHitFX.Play();
                Destroy(obj.gameObject);
            }
        }
        if (bossColor.a <= 0.0f) {
            Destroy(boss);
        }

    }
}
