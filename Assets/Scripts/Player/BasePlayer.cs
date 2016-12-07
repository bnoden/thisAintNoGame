using UnityEngine;
using System.Collections;

public class BasePlayer {

    private string name;
    private string type;

    private int level;
    private int attack;
    private int hit;
    private int defense;
    private int hpMax;
    private int hp;
    private int mpMax;
    private int mp;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Type {
        get { return type; }
        set { type = value; }
    }

    public int Level {
        get { return level; }
        set { level = value; }
    }

    public int Attack {
        get { return attack; }
        set { attack = value; }
    }

    public int Hit {
        get { return hit; }
        set { hit = value; }
    }

    public int Defense {
        get { return defense; }
        set { defense = value; }
    }

    public int HPMax {
        get { return hpMax; }
        set { hpMax = value; }
    }

    public int MPMax {
        get { return mpMax; }
        set { mpMax = value; }
    }

    public int HP {
        get { return hp; }
        set { hp = value; }
    }

    public int MP {
        get { return mp; }
        set { mp = value; }
    }



}
