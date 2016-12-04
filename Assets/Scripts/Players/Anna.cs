using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Anna : MonoBehaviour {

	public GameObject player;
    public GameObject edward;
    public GameObject anna;
    public static float hp = 0f;
    public Vector3 annaPos;
    bool isSaved = false;

    Color color;

    public SpriteRenderer spriteParent;
    public GameObject target;
    public static int direction;

    public static bool followLeader = false;

    void Start() {
        color = anna.GetComponent<SpriteRenderer>().color;
        annaPos -= transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate()
    {
        if (followLeader) {
            this.transform.position = PlayerMovement.leaderMovements.ElementAtOrDefault(35);
            isSaved = true;
        }

    }

    void OnCollisionEnter2D(Collision2D obj) {
        if (player) {
            followLeader = true;
            
        }
        if (player || edward) {
            if (followLeader) {
                Physics2D.IgnoreCollision(obj.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
            }
        }
    }

    public void setSaved(bool saved) {
        isSaved = saved;
    }

    public bool getSaved() {
        return isSaved;
    }




}
