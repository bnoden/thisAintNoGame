using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    public float Xmin = 6.0f;
    public float Xmax = 27.0f;
    public float Ymin = -6.0f;
    public float Ymax = 36.0f;

	// Use this for initialization
	void Start () {
	    offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
	    MoveCam();
	}
    
    void MoveCam() {
        Vector3 playerPos = player.transform.position;
        Vector3 camPos = transform.position;

        camPos.x = Mathf.Clamp(playerPos.x, Xmin, Xmax);
        camPos.y = Mathf.Clamp(playerPos.y, Ymin, Ymax);

        transform.position = camPos;
    }




}
