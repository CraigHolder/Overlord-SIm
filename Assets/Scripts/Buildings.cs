using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings
{
    public static bool init = false;

    public static BuildingStats Houses;
    public static BuildingStats Farm;
    public static BuildingStats Stable;

    public static BuildingStats Church;
    public static BuildingStats Graveyard;
    public static BuildingStats Library;

    public static BuildingStats Barracks;
    public static BuildingStats Prison;
    public static BuildingStats Tower;

    public static BuildingStats Glassblower;
    public static BuildingStats Brewer;

    public static BuildingStats Lumbermill;

    public static BuildingStats Mine;
    public static BuildingStats Mason;

    public static BuildingStats Forge;
    public static BuildingStats WeaponSmith;
    public static BuildingStats ArmorSmith;

    public static BuildingStats Market;

    public static BuildingStats Inn;
    public static BuildingStats Brothel;

    public static BuildingStats HealingHut;

    public static List<BuildingStats> DefaultBuildings()
    {
        if(!init)
        {
            Init();
        }
        List <BuildingStats> temp = new List<BuildingStats>();
        temp.Add(Houses);
        temp.Add(Church);
        temp.Add(Barracks);
        temp.Add(Glassblower);
        temp.Add(Lumbermill);
        temp.Add(Mine);
        temp.Add(Prison);
        temp.Add(Forge);
        temp.Add(Market);
        temp.Add(Inn);
        temp.Add(HealingHut);


        return temp;
    }

    public static void Init()
    {
        init = true;
    }

    


}
