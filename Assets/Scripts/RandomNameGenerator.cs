using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemPrefix
{
    A1 = 0, A2,A3,A4,A5,A6,A7
}

public enum ItemPostfix
{
    a1 = 0, a2,a3,a4,a5,a6,a7
}

public class RandomNameGenerator
{
    public int ITEM_MAX_OPTION_COUNT = 7;
    private string nameToReturn;

    public RandomNameGenerator()
    {
        Debug.Log("Make Random Name");
        nameToReturn = MakeRandomName();
    }

    private string MakeRandomName()
    {
        int randomValue1 = Random.Range(0, ITEM_MAX_OPTION_COUNT);
        int randomValue2 = Random.Range(0, ITEM_MAX_OPTION_COUNT);
        string returnName = "";

        switch (randomValue1){

            case 0:
                returnName += "A1";
                break;
            case 1:
                returnName += "A2";
                break;
            case 2:
                returnName += "A3";
                break;
            case 3:
                returnName += "A4";
                break;
            case 4:
                returnName += "A5";
                break;
            case 5:
                returnName += "A6";
                break;
            case 6:
                returnName += "A7";
                break;

        }

        switch (randomValue2)
        {

            case 0:
                returnName += "a1";
                break;
            case 1:
                returnName += "a2";
                break;
            case 2:
                returnName += "a3";
                break;
            case 3:
                returnName += "a4";
                break;
            case 4:
                returnName += "a5";
                break;
            case 5:
                returnName += "a6";
                break;
            case 6:
                returnName += "a7";
                break;

        }

        return returnName;
    }

    public string getRandomName()
    {
        return nameToReturn;
    }

}
