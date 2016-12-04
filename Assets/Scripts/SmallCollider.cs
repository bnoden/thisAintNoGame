using UnityEngine;
using System.Collections;

public class SmallCollider : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Harp") {
            Physics2D.IgnoreCollision(obj.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        }
        
    }
}
