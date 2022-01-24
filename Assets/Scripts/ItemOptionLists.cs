using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOptionLists 
{
    private static int ITEM_MAX_OPTION_LIST = 100;
    
    public string[] itemOptions = new string[ITEM_MAX_OPTION_LIST];
    
    public ItemOptionLists()
    {
        Debug.Log("Set Item Options");

        itemOptions[0] = "Damage";
        itemOptions[1] = "Strength";
        itemOptions[2] = "Dexterity";
        itemOptions[3] = "Socket";
    }

}
