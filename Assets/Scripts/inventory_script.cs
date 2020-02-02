using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_script : MonoBehaviour
{
    private bool inventoryEnabled = true;
    public GameObject inventory;
    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;
    
    

    void Start()
    {
        allSlots = 1;
        slot = new GameObject[allSlots];
        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
            

        
        }
    }


    void Update()
    {
        //print(inventory.transform.GetChild(0).GetChild(0).ToString());

        inventory.transform.GetChild(0).GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = FirstPersonAIO.cogCounter.ToString();
        

        if (Input.GetKeyDown(KeyCode.I))

        if (inventoryEnabled == true)
            {
                inventoryEnabled = !inventoryEnabled;
                inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }
}
