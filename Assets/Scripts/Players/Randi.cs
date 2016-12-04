using UnityEngine;
using System.Collections;

public class Randi : MonoBehaviour {

    public GameObject randi;
    public GameObject tool;
    //public Transform harpPrefab;

    const int lvBase = 1; const int hpBase = 50; const int mpBase = 8;
    const int MIN_HP = 0; const int MIN_MP = 0;
    const int MAX_HP = 999; const int MAX_MP = 99;
    public int lv;
    public int hp, hpMax, mp, mpMax;
    //public static int exp = 0;

    System.Random r = new System.Random();

	// Use this for initialization
	void Start () {
	    InitRandi();
        //Physics.IgnoreCollision(harpPrefab.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () {

	}

    void InitRandi() {
        //lv = lvBase;
        hpMax = hpBase; mpMax = mpBase; hp = hpMax; mp = mpMax;

        if (lv > lvBase) {
            for (int i = 2; i <= lv; i++) {
                hpMax+=r.Next(9, 17);
                mpMax+=r.Next(1, 3);
                if (hpMax > MAX_HP) {
                    hpMax = MAX_HP;
                }
                if (mpMax > MAX_MP) {
                    mpMax = MAX_MP;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D obj) {

    }








}
