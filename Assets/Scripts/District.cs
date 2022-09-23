using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class District : MonoBehaviour
{
    public Faction faction;

    public List<Building> buildings;
    public City parentCity;

    public List<Resource> expenses;
    public List<Resource> profits;

    public List<Population> growth;

    [SerializeField]
    SpriteRenderer sR;

    // Start is called before the first frame update
    void Start()
    {
        buildings = new List<Building>();

        expenses = new List<Resource>();
        profits = new List<Resource>();

        growth = new List<Population>();

        sR.color = faction.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateData()
    {
        expenses.Clear();
        profits.Clear();

        growth.Clear();

        foreach (Building b in buildings)
        {
            foreach (Resource r in b.expenses)
            {
                expenses.Add(r);
            }
            foreach (Resource r in b.profits)
            {
                profits.Add(r);
            }
            foreach (Population p in b.growth)
            {
                growth.Add(p);
            }
        }
    }
}
