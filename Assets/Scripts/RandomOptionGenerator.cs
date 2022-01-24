using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOptionGenerator 
{
    private int MIN_ITEM_OPTION_COUNTS = 1;
    private int MAX_ITEM_OPTION_COUNTS = 6;

    private int maxItemOptionCounts;

    public RandomOptionGenerator()
    {
        Debug.Log("Random Option Generator");

        // ������ 1�̰�, 7��. �� 1234567 
        maxItemOptionCounts = Random.Range(1, 7);
    }

    public List<string> CombineOptions()
    {
        List<string> tempOptionCombination = new List<string>();
        ItemOptionLists tempOptionLists = new ItemOptionLists();

        // �����ϰ� �ִ�� ������ �ִ� �ɼ��� ������.        
        for(int i = 0; i < maxItemOptionCounts; i++)
        {
            //tempOptionCombination.Add(tempOptionLists.itemOptions[```�ɼ� ���� ����```]);
            tempOptionCombination.Add(tempOptionLists.itemOptions[Random.Range(0, 3)]);
        }
        return tempOptionCombination;

    }




    

    
}
