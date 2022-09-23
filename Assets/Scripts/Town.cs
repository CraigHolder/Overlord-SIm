using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : MonoBehaviour
{
    public Faction faction;

    public List<Resource> expenses;
    public List<Resource> profits;

    public List<Population> populations;
    public List<Population> growth;

    public List<Building> buildings;
    public float buildingRange = 25;
    public int buildingLimit = 0;

    [SerializeField]
    SpriteRenderer sR;

    // Start is called before the first frame update
    void Start()
    {
        expenses = new List<Resource>();
        profits = new List<Resource>();

        populations = new List<Population>();
        growth = new List<Population>();

        buildings = new List<Building>();

        sR.color = faction.color;

        int pop = 0;
        foreach(Population p in populations)
        {
            pop += (int)p.amount / 20;
        }
        buildingLimit = pop;
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
