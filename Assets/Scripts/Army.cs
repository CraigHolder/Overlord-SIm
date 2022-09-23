using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public Faction faction;
    public Race race;
    public int soldiers = 100;
    public int magic = 1;
    public int martial = 1;
    public int mischief = 1;

    public List<Resource> cost;
    public List<Resource> upkeep;

    [SerializeField]
    SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        sR.color = faction.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
