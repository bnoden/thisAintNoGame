using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBox : MonoBehaviour {

    public GameObject textbox;
    //public PlayerMovement player;
    
    private Canvas canvas;
    private bool loaded;

	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();
        //player = GetComponent<PlayerMovement>();
        toggle();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.N)) {
          //      toggle();
            //}
	}



    public bool isLoaded() {
        return loaded;
    }

    public void toggle() {
        canvas.enabled = !canvas.enabled;
        loaded = !loaded;
    }
}
