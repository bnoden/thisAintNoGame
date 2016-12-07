using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hpHero : MonoBehaviour {

    private BasePlayer hero = new Hero();

    private Text text;

	// Use this for initialization
	void Start () {
	    text = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = hero.HP.ToString() + "/" + hero.HPMax.ToString();
	}




}
