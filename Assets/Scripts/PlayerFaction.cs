using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFaction : Faction
{
    [SerializeField]
    Image resourcesBackground;
    [SerializeField]
    Transform resourceUI;

    public GameObject resourceUIPrefab;

    

    public List<Town> Towns;
    public List<City> Cities;


    // Start is called before the first frame update
    public override void Start()
    {
        resources = new List<Resource>();
        expenses = new List<Resource>();
        profits = new List<Resource>();
        populations = new List<Population>();

        int size = resources.Count / 12;
        size *= 56;
        resourcesBackground.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);

        AddResource(Resources.Coin, 100);
        AddResource(Resources.Wood, 50);
        AddResource(Resources.Meat, 500);
        AddResource(Resources.Metal, 100);
        AddResource(Resources.Stone, 50);
        AddResource(Resources.Grain, 500);
        AddResource(Resources.Bows, 5);
        AddResource(Resources.Spears, 5);
        AddResource(Resources.Shields, 5);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }

    }
    public override void AddResource(Resource r)
    {
        bool hasResource = false;
        for (int i = 0; i < resources.Count; i++)
        {
            if (resources[i].name == r.name)
            {
                hasResource = true;
                Resource temp = new Resource();
                temp.amount = resources[i].amount + r.amount;
                temp.name = r.name;
                temp.description = resources[i].description;
                temp.gO = resources[i].gO;
                resources[i] = temp;
                resources[i].gO.GetComponent<TMPro.TMP_Text>().text = "" + resources[i].name + ": " + resources[i].amount;
                break;
            }
        }
        if (!hasResource)
        {
            resources.Add(r);
            GameObject gO = Instantiate<GameObject>(resourceUIPrefab, resourceUI);
            gO.GetComponent<TMPro.TMP_Text>().text = "" + r.name + ": " + r.amount;
            int size = 1;//resources.Count / 8;
            if (resources.Count > 8)
            {
                size = 2;
                if (resources.Count > 16)
                {
                    size = 3;
                    if (resources.Count > 24)
                    {
                        size = 4;
                        if (resources.Count > 32)
                        {
                            size = 5;
                        }
                    }

                }
            }
            //size++;
            size *= 56;
            resourcesBackground.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);
            
        }
    }
    public override void AddResource(Resource r, float a)
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
                temp.gO = resources[i].gO;
                resources[i] = temp;
                resources[i].gO.GetComponent<TMPro.TMP_Text>().text = "" + r.name + ": " + resources[i].amount;
                break;
            }
        }
        if (!hasResource)
        {
            GameObject gO = Instantiate<GameObject>(resourceUIPrefab, resourceUI);
            r.gO = gO;
            r.amount = a;
            resources.Add(r);
            gO.GetComponent<TMPro.TMP_Text>().text = "" + r.name + ": " + a;
            int size = 1;//resources.Count / 8;
            if(resources.Count > 8)
            {
                size = 2;
                if (resources.Count > 16)
                {
                    size = 3;
                    if (resources.Count > 24)
                    {
                        size = 4;
                        if (resources.Count > 32)
                        {
                            size = 5;
                        }
                    }
                    
                }
            }
            //size++;
            size *= 56;
            resourcesBackground.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size);
        }
    }

    public static void Build(BuildingStats building)
    {

    }

}
