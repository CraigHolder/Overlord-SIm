using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Faction faction;
    public District parentDistrict;
    public Town parentTown;

    public List<Resource> expenses;
    public List<Resource> profits;
    public List<Population> growth;

    [SerializeField]
    SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        expenses = new List<Resource>();
        profits = new List<Resource>();
        growth = new List<Population>();

        sR.color = faction.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
