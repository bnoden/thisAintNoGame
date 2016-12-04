using UnityEngine;
using System.Collections;

public class SpaceCollider : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Harp") {
            Destroy(obj.gameObject);
        }
    }
}
