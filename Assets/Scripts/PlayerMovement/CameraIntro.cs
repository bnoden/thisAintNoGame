using UnityEngine;
using System.Collections;

public class CameraIntro : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    public static float Xmin = -60.0f;
    public static float Xmax = 66.0f;
    public static float Ymin = -80.0f;
    public static float Ymax = 56.0f;

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
