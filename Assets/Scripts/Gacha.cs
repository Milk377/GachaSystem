using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetGacha();
    }

    public void GetGacha()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Press Alpha1. Get Gacha()");
            Item item = new Item("item1", "rare", 1);
        }
    }
}
