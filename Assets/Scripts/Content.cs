using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Content : MonoBehaviour {

    public static Text text;
    public Edward edward;
    public TextBox textbox;
    public GameObject content;
    private int lineNum = 0;

	// Use this for initialization
	void Start () {
	    text = this.GetComponent<Text>();
        edward = gameObject.GetComponent<Edward>();
        setText(0);
        
        //textbox = this.GetComponent<TextBox>();
        //OpenBox();
	}
	
	// Update is called once per frame
	void Update () {

	}
    
    public void OpenBox() {
        textbox.toggle();
        
    }

    private string[] lines = {
        "Organ music is evil! Get that thing outta here!",   // 0
        "Thank you!\n ...\nThat voice is...\nAnna?"  // 1
    };

    public string getText(int num) {
        return lines[num];
    }
    
    public void setText(int num) {
        //text.text = lines[num];
        content.GetComponent<Text>().text = text.text;
        text.text = lines[num];
    }






}
