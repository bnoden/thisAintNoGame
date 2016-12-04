using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {

    static float walk = 2.0f, sprint = walk+2.0f;
    static float offset = 0.05f;
    static int up = 0, down = 1, left = 2, right = 3;
    public static bool isMoving = false;
    public static int facing;
    public Animator anim;
    public Vector3 playerPos;
    public GameObject player2;

    public GameObject harp;
    public GameObject note;
    public static float projectileSpeed = 10f;
    public static float projectileRepeatRate = 0.2f;
    public Meter meter;

    public AudioSource harpFX;
    public AudioSource harpBigFX;
    public static Queue<Vector3> leaderMovements = new Queue<Vector3>();
    public static Vector3 leaderLastPosition;

    void Start () {
        anim = GetComponent<Animator>();
        Face(down);
    }

    void PlayHarp() {
        GameObject note = Instantiate(harp, player2.transform.position, transform.localRotation) as GameObject;
        
        if (meter.getAlpha() >= 1.0f) {
                float noteScale = 16.0f;
                meter.setAlpha(1.0f);
                Debug.Log("Meter alpha is " + meter.getAlpha());
                note.transform.localScale = new Vector3(noteScale, noteScale);
            }

        note.GetComponent<Rigidbody2D>().velocity = new Vector3(playerPos.x, playerPos.y, 0);

        if (meter.getAlpha() >= 1.0f) { harpBigFX.Play(); }
        if (meter.getAlpha() < 1.0f) { harpFX.Play(); }
    }
    
    // Update is called once per frame
    void Update () {
        anim = GetComponent<Animator>();
        float step = walk;
        
        if(Input.GetKey(KeyCode.LeftShift)) {
            step = sprint;
        }
        Move(step);

        if(Input.GetKeyDown(KeyCode.Space)){
            CancelInvoke("ReleaseMeter");
            InvokeRepeating("ChargeMeter", 0.0001f, projectileRepeatRate);
            PlayHarp();
            meter.ChargeFX(true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            //GameObject note = Instantiate(harp, player2.transform.position, Quaternion.identity) as GameObject;
            PlayHarp();
            CancelInvoke("ChargeMeter");
            InvokeRepeating("ReleaseMeter", 0.0001f, projectileRepeatRate);
            meter.ChargeFX(false);
            
        }

        if (leaderLastPosition != (Vector3)this.transform.position)
        {
            leaderMovements.Enqueue(this.transform.position);
        }

        if (leaderMovements.Count > 50)
        {
            leaderMovements.Dequeue();
        }
        leaderLastPosition = this.transform.position;

    }

    void ReleaseMeter() {
        meter.Release();
        
    }

    void ChargeMeter() {
        meter.Charge();
        
    }

    

    /*
for "walk":
0 = walk up
1 = walk down
2 = walk left
3 = walk right

4 = idle up
5 = idle down
6 = idle left
7 = idle right

8 = run up
9 = run down
10 = run left
11 = run right 
     */

    public void Move(float speed) {
        bool UP = Input.GetKey(KeyCode.UpArrow), DOWN = Input.GetKey(KeyCode.DownArrow),
            LEFT = Input.GetKey(KeyCode.LeftArrow), RIGHT = Input.GetKey(KeyCode.RightArrow);
        playerPos = transform.position;

        if (isMoving) { anim.SetBool("isMoving", true); }
        else { anim.SetBool("isMoving", false); }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
                isMoving = false;
                Face(up);
            }
        if (UP) {
            isMoving = true;
            if(Input.GetKey(KeyCode.LeftShift)) {
            anim.SetInteger("walk", up+8);
        } else {
                anim.SetInteger("walk", up);
            }
            
            playerPos+=Vector3.up*(speed*offset);
            
        }
        
        if (DOWN) {
            isMoving = true;
             if(Input.GetKey(KeyCode.LeftShift)) {
            anim.SetInteger("walk", down+8);
        } else {
                anim.SetInteger("walk", down);
            }
            
            playerPos+=Vector3.down*(speed*offset);
            
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
                isMoving = false;
                Face(down);
            }
        if (LEFT) {
            isMoving = true;
            if(Input.GetKey(KeyCode.LeftShift)) {
            anim.SetInteger("walk", left+8);
        } else {
                anim.SetInteger("walk", left);
            }
            
            playerPos+=Vector3.left*(speed*offset);
            
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
                isMoving = false;
                Face(left);
            }
        if (RIGHT) {
            isMoving = true;
            if(Input.GetKey(KeyCode.LeftShift)) {
            anim.SetInteger("walk", right+8);
        } else {
                anim.SetInteger("walk", right);
            }
            
            playerPos+=Vector3.right*(speed*offset);
            
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
                isMoving = false;
                Face(right);
            }
        transform.position = playerPos;

    }

    void Sprint(int pace) {
        pace += 8;
        anim.SetInteger("walk", pace);
    }

    void Face(int direction) {
        direction += 4;
        anim.SetInteger("walk", direction);
    }




}
