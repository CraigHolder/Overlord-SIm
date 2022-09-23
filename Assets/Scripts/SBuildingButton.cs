using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBuildingButton : MonoBehaviour
{
    public BuildingStats building;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Build()
    {
        PlayerFaction.Build(building);
    }
}
