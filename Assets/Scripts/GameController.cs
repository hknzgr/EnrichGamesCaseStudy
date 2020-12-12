using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int n;
    public GameObject slot;


    private void Start()
    {
        CreateGrid();
    }
    public void CreateGrid()
    {
        for (int i = 0; i < n*n; i++)
        {
            GameObject slotN = Instantiate(slot, GameObject.Find("GridPanel").transform.position, Quaternion.identity);
            slotN.transform.SetParent(GameObject.Find("GridPanel").transform);
            slotN.name = (i+1).ToString();
        }
    }

  
    



   
}
