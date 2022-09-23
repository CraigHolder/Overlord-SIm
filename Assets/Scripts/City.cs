using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public Faction faction;

    public List<Resource> expenses;
    public List<Resource> profits;

    public List<Population> populations;
    public List<Population> growth;

    public List<District> districts;

    [SerializeField]
    SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        expenses = new List<Resource>();
        profits = new List<Resource>();

        populations = new List<Population>();
        growth = new List<Population>();

        districts = new List<District>();

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

        foreach (District d in districts)
        {
            foreach (Resource r in d.expenses)
            {
                expenses.Add(r);
            }
            foreach (Resource r in d.profits)
            {
                profits.Add(r);
            }
            foreach (Population p in d.growth)
            {
                growth.Add(p);
            }
        }
    }
}
