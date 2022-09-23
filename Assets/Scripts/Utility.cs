
using System;
using System.Collections.Generic;
using UnityEngine;

public struct Character
{
    public string name;
    public string title;
    public float age;
    public Race race;
    //stats
    public float strength;
    public float fortitude;
    public float intelligence;
    public float charisma;
    //skills
    public float magic;
    public float martial;
    public float mischief;
    //specials
    public List<Ability> ability;

    //public Character(string Name, float Age, float stength, float fortitude, float intelligence, float charisma, float magic, float martial, float mischief)
    //{
    //     this.name = Name;
    //    this.age = Age;

    //    this.strength = stength;
    //    this.fortitude = fortitude;
    //    this.intelligence = intelligence;
    //    this.charisma = charisma;

    //    this.magic = magic;
    //    this.martial = martial;
    //    this.mischief = mischief;
    //    this.ability = new List<Ability>();
    //}
    //public Character(string Name, float Age, float stength, float fortitude, float intelligence, float charisma, float magic, float martial, float mischief, List<Ability> abilitys)
    //{
    //    this.name = Name;
    //    this.age = Age;

    //    this.strength = stength;
    //    this.fortitude = fortitude;
    //    this.intelligence = intelligence;
    //    this.charisma = charisma;

    //    this.magic = magic;
    //    this.martial = martial;
    //    this.mischief = mischief;
    //    this.ability = abilitys;
    //}
}

public enum PlayerState
{
    PlacingBuilding,
    PlacingDistrict,
    PlacingCity,
    PlacingTown,
    Event


}

public struct Ability
{
    public string name;
    public string description;
    public List<ResourceModifier> resourceBonuses;
    public List<EventBonus> eventBonuss;
    public float coolDown;
    public bool isAutomatic;
    

}

public struct ResourceModifier
{
    public Resource resource;
    public float amount;
}

public struct EventCondition
{
    public string tag;
}
[Serializable]
public struct Resource
{
    public string name;
    public string description;
    public float amount;
    public GameObject gO;
}

public struct EventBonus
{
    public string tag;
}


public struct EventStep
{
    public string name;
    public List<EventStep> nextSteps;
    public List<ResourceModifier> resourceConditions;
    public List<EventCondition> eventConditions;
}
[Serializable]
public struct Population
{
    public Race race;
    public long amount;
}

[Serializable]
public struct BuildingStats
{
    public List<Resource> cost;
    public List<Resource> expenses;
    public List<Resource> profits;
    public List<Population> growth;
}

public enum Race
{
    Human,
    Elf,
    Dwarf,
    Undead,
    Demon,
    Monster
}