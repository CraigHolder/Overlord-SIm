using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources
{
    public static Resource Coin;
    //supplies 3
    public static Resource Meat;
    public static Resource Grain;
    public static Resource Liquor;
    //basic materials 3
    public static Resource Wood;
    public static Resource Stone;
    public static Resource Metal;
    //healing 2
    public static Resource LifeMoss;
    public static Resource HealingPotions;
    //military 6
    public static Resource Spears;
    public static Resource Shields;
    public static Resource Armor;
    public static Resource Swords;
    public static Resource Bows;
    public static Resource SpellBooks;
    //dark magic 5
    public static Resource Souls;
    public static Resource BBlood;
    public static Resource Bones;
    public static Resource FreshCorpses;
    public static Resource Prisoners;

    public static void InitResources()
    {
        Coin = new Resource();
        Coin.name = "Coin";
        Coin.description = "various currencies";
        Coin.amount = 0;

        Meat = new Resource();
        Meat.name = "Meat";
        Meat.description = "supplies to keep the masses satieted";
        Meat.amount = 0;

        Grain = new Resource();
        Grain.name = "Grain";
        Grain.description = "supplies to keep the masses satieted";
        Grain.amount = 0;

        Liquor = new Resource();
        Liquor.name = "Liquor";
        Liquor.description = "supplies to keep the masses satieted";
        Liquor.amount = 0;

        //basic materials//////////////////////////////////////////////////////////////
        Wood = new Resource();
        Wood.name = "Wood";
        Wood.description = "Refined Lumber";
        Wood.amount = 0;

        Stone = new Resource();
        Stone.name = "Stone";
        Stone.description = "Refined Stone";
        Stone.amount = 0;

        Metal = new Resource();
        Metal.name = "Metal";
        Metal.description = "Refined Metal";
        Metal.amount = 0;
        //healing//////////////////////////////////////////////////////////////////////
        LifeMoss = new Resource();
        LifeMoss.name = "Wood";
        LifeMoss.description = "Healing Moss";
        LifeMoss.amount = 0;

        HealingPotions = new Resource();
        HealingPotions.name = "Wood";
        HealingPotions.description = "Life saver";
        HealingPotions.amount = 0;

        //military//////////////////////////////////////////////////////////////////////
        Spears = new Resource();
        Spears.name = "Spears";
        Spears.description = "Simple Spears";
        Spears.amount = 0;

        Shields = new Resource();
        Shields.name = "Shields";
        Shields.description = "Simple Shields";
        Shields.amount = 0;

        Armor = new Resource();
        Armor.name = "Armor";
        Armor.description = "Sturdy Armor";
        Armor.amount = 0;

        Swords = new Resource();
        Swords.name = "Swords";
        Swords.description = "Trusty Sword";
        Swords.amount = 0;

        Bows = new Resource();
        Bows.name = "Bows";
        Bows.description = "Deadly Bows";
        Bows.amount = 0;

        SpellBooks = new Resource();
        SpellBooks.name = "SpellBooks";
        SpellBooks.description = "Powerful Spellbooks";
        SpellBooks.amount = 0;

        //dark magic//////////////////////////////////////////////////////////////////////
        Souls = new Resource();
        Souls.name = "Souls";
        Souls.description = "Captured Souls";
        Souls.amount = 0;

        BBlood = new Resource();
        BBlood.name = "BBlood";
        BBlood.description = "Bottled Blood";
        BBlood.amount = 0;

        Bones = new Resource();
        Bones.name = "Bones";
        Bones.description = "Random Bones";
        Bones.amount = 0;

        FreshCorpses = new Resource();
        FreshCorpses.name = "FreshCorpses";
        FreshCorpses.description = "Fresh Corpses";
        FreshCorpses.amount = 0;

        Prisoners = new Resource();
        Prisoners.name = "Prisoners";
        Prisoners.description = "Prisoners";
        Prisoners.amount = 0;
    }
}
