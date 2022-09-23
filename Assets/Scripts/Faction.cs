using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faction : MonoBehaviour
{
    [SerializeField]
    public List<Resource> resources;

    public List<Resource> expenses;
    public List<Resource> profits;

    public List<Resource> modifiers;

    public List<Population> populations;
    public List<Population> growth;

    public Color color;

    public List<BuildingStats> unlockedBuildings;

    public City selectedCity;
    public Town selectedTown;
    public Building selectedBuilding;
    public District selectedDistrict;

    // Start is called before the first frame update
    public virtual void Start()
    {
        resources = new List<Resource>();

        expenses = new List<Resource>();
        profits = new List<Resource>();

        modifiers = new List<Resource>();

        populations = new List<Population>();
        growth = new List<Population>();

        unlockedBuildings = Buildings.DefaultBuildings();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DailyUpdate()
    {
        for (int i = 0; i < profits.Count; i++)
        {
            AddResource(profits[i]);
        }
        for (int i = 0; i < expenses.Count; i++)
        {
            AddResource(expenses[i]);
        }
        for (int i = 0; i < growth.Count; i++)
        {
            AddPopulation(growth[i]);
        }
    }

    public virtual void AddResource(Resource r)
    {
        bool hasResource = false;
        for (int i = 0; i < resources.Count; i++)
        {
            if(resources[i].name == r.name)
            {
                hasResource = true;
                Resource temp = new Resource();
                temp.amount = resources[i].amount + r.amount;
                temp.name = r.name;
                temp.description = resources[i].description;
                resources[i] = temp;
                break;
            }
        }
        if(!hasResource)
        {
            resources.Add(r);
        }
    }
    public virtual void AddResource(Resource r, float a)
    {
        bool hasResource = false;
        for (int i = 0; i < resources.Count; i++)
        {
            if (resources[i].name == r.name)
            {
                hasResource = true;
                Resource temp = new Resource();
                temp.amount = resources[i].amount + a;
                temp.name = r.name;
                temp.description = resources[i].description;
                resources[i] = temp;
                break;
            }
        }
        if (!hasResource)
        {
            r.amount = a;
            resources.Add(r);
        }
    }
    public virtual void AddPopulation(Population p)
    {
        bool hasPopulation = false;
        for (int i = 0; i < resources.Count; i++)
        {
            if (populations[i].race == p.race)
            {
                hasPopulation = true;
                Population temp = new Population();
                temp.amount = populations[i].amount + p.amount;
                temp.race = p.race;
                populations[i] = temp;
                break;
            }
        }
        if (!hasPopulation)
        {
            populations.Add(p);
        }
    }

    //public virtual void Build(BuildingStats building)
    //{
    //
    //}
}
