using UnityEngine;
using System.Collections;

public class Meter : MonoBehaviour {

    public GameObject meter;
    public AudioSource chargeFX;

    Color meterColor;


	// Use this for initialization
	void Start () {
	   meterColor = meter.GetComponent<SpriteRenderer>().color;
	}
	
	// Update is called once per frame
	void Update () {
	    

	}

    public void ChargeFX(bool enabled) {
        if (enabled == true) {
            chargeFX.Play();
        }
        if (enabled == false) {
            chargeFX.Stop();
        }
    }

    public void Release() {
        if (meterColor.a > 0.0f) {
            //chargeFX.Stop();
            meterColor.a-=0.1f;
            //if (meterColor.a < 0.0f) { meterColor.a = 0.0f; }
            meter.GetComponent<SpriteRenderer>().color = meterColor;
        }
    }

    public void Charge() {
        if (meterColor.a < 1.0f) {
            meterColor.a+=0.04f;
            //if (meterColor.a > 1.0f) { meterColor.a = 1.0f; }
            meter.GetComponent<SpriteRenderer>().color = meterColor;
        }
    }

    public void setAlpha(float alpha) {
        meterColor.a = alpha;
    }

    public float getAlpha() {
        return meterColor.a;
    }
}
