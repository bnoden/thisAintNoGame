using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Edward : MonoBehaviour {

    public GameObject edward;
    public GameObject player;
    public Animator anim;
    public TextBox textbox;
    public Content content;
    public Organ organ;
    
    public int hp = 100;

    bool followLeader = false;
    private bool hiding;

    void Start() {
        anim = GetComponent<Animator>();
        anim.SetInteger("position", 2);
    }
    
    // Update is called once per frame
    void Update () {
        if (!textbox.isLoaded()) {
            if (Input.anyKeyDown) {
                if (anim.GetInteger("position") == 1) {
                    if (organ) {
                        anim.SetInteger("position", 2);
                    }
                }
                textbox.toggle();
            }
        }
    }

    void LateUpdate()
    {
        if (followLeader) {
            transform.position = PlayerMovement.leaderMovements.ElementAtOrDefault(20);
        }

    }

    void OnCollisionEnter2D(Collision2D obj) {
        Debug.Log("You touched Edward");
        
        if (obj.gameObject.tag == "Player") {
            if (followLeader) {
                Physics2D.IgnoreCollision(obj.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
            }
            
            textbox.toggle();
            if (!organ) { followLeader = true; }
            
        }
    }

    public bool getFollow() { return followLeader; }

    public void Stand() { anim.SetInteger("position", 1); }

    public void Hide() { anim.SetInteger("position", 2); }

    public bool isHiding() {
        if (anim.GetInteger("position") == 1) { hiding = false; }
        if (anim.GetInteger("position") == 2) { hiding = true; }
        return hiding;
    }







}
