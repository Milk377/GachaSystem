using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Item 
{
    private string ItemName;
    private string ItemType;
    private int ItemLevel;
    public static int totalItemCounts = 0;

    public List<string> ItemOptions;


    public Item()
    {
        Debug.Log("Create Item() with Default Constructor");
        totalItemCounts++;
    }

    public Item(string _ItemName, string _ItemType, int _ItemLevel)
    {
        
        try
        {
            Debug.Log("Create Item() Constructor with 3 Parameters ");
            
            // Create Item Name
            RandomNameGenerator RN = new RandomNameGenerator();
            ItemName = RN.getRandomName();

            // Combine Item Options
            RandomOptionGenerator RO = new RandomOptionGenerator();
            ItemOptions = RO.CombineOptions();

            ItemType = _ItemType;
            ItemLevel = _ItemLevel;
            totalItemCounts++;

            Debug.Log("Total Item Counts are : " + totalItemCounts);
            Debug.Log("Make Item : " + ItemName);

            for(int i = 0; i < ItemOptions.Count; i++)
            {
                Debug.Log(ItemOptions[i]);
            }

        }
        catch (Exception e)
        {
            Debug.Log("Can't Create Item." + e.Message);

        }
    }
}
