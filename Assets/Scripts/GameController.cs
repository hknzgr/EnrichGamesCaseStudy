using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int n;
    public Text nText;
    public GameObject slot;
    public GameObject grid;
    List<GameObject> gridIndex = new List<GameObject>();

    private void Start()
    {
        n = int.Parse(nText.text);
    }

    public void CreateGrid()
    {
        n = int.Parse(nText.text);

        ClearGrid();

        for (int i = 0; i < n*n; i++)
        {
            GameObject slotN = Instantiate(slot, grid.transform.position, Quaternion.identity);
            slotN.transform.SetParent(grid.transform);
            gridIndex.Add(slotN);
            slotN.name = (i+1).ToString();
        }

    }

    public void ClearGrid()
    {
        foreach (var item in gridIndex)
        {
            Destroy(item.gameObject);
        }
    }

  
    



   
}
