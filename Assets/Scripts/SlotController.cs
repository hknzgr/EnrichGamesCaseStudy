using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlotController : MonoBehaviour
{    
    List<GameObject> slots = new List<GameObject>();

    public void Controller()
    {
        foreach (var item in this.gameObject.GetComponent<Slot>().Targets)
        {
            if (item.gameObject.GetComponent<Slot>().Clicked==true && !slots.Contains(item))
            {
                slots.Add(item);
                foreach (var item2 in item.gameObject.GetComponent<Slot>().Targets )
                {
                    if (item2.gameObject.GetComponent<Slot>().Clicked == true && !slots.Contains(item2))
                    {
                        slots.Add(item2);
                    } 
                }
            }
        }

        if (slots.Count>=3)
        {
            foreach (var item in slots)
            {
                item.GetComponent<Slot>().Clicked = false;
                item.GetComponent<Image>().sprite = null;
            }
            slots.Clear();
        }
    }
}
