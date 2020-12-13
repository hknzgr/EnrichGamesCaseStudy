using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public string Name;
    public string Position;
    public bool Clicked;
    public List<GameObject> Targets = new List<GameObject>();
    int n,x;

    void Start()
    {
        Invoke("Properties", 1);
        
    }

    public void ButtonCliked()
    {
        Clicked = true;
    }

    public void Properties()
    {

        n = GameController.n;
        x = int.Parse(this.gameObject.name);
        Name = this.gameObject.name;
        if (Name == "1")
        {
            Position = "UpperLeftCorner";
            Targets.Add(GameObject.Find((x + 1).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));

        }
        else if (Name == n.ToString())
        {
            Position = "UpperRightCorner";
            Targets.Add(GameObject.Find((x - 1).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));
        }
        else if (Name == ((n * n) - n + 1).ToString())
        {
            Position = "LowerLeftCorner";
            Targets.Add(GameObject.Find((x - n).ToString()));
            Targets.Add(GameObject.Find((x + 1).ToString()));
        }
        else if (Name == (n * n).ToString())
        {
            Position = "LowerRightCorner";
            Targets.Add(GameObject.Find((x - n).ToString()));
            Targets.Add(GameObject.Find((x - 1).ToString()));
        }
        else if (int.Parse(Name) < n && int.Parse(Name) > 1)
        {
            Position = "Upper";
            Targets.Add(GameObject.Find((x - 1).ToString()));
            Targets.Add(GameObject.Find((x + 1).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));
        }
        else if (int.Parse(Name) < n * n && int.Parse(Name) > (n * n) - n + 1)
        {
            Position = "Lower";
            Targets.Add(GameObject.Find((x - 1).ToString()));
            Targets.Add(GameObject.Find((x + 1).ToString()));
            Targets.Add(GameObject.Find((x - n).ToString()));
        }
        else if (int.Parse(Name) % n == 1 && Position == "")
        {
            Position = "Left";
            Targets.Add(GameObject.Find((x + 1).ToString()));
            Targets.Add(GameObject.Find((x - n).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));
        }
        else if (int.Parse(Name) % n == 0 && Position == "")
        {
            Position = "Right";
            Targets.Add(GameObject.Find((x - 1).ToString()));
            Targets.Add(GameObject.Find((x - n).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));
        }
        else
        {
            Position = "Middle";
            Targets.Add(GameObject.Find((x - 1).ToString()));
            Targets.Add(GameObject.Find((x + 1).ToString()));
            Targets.Add(GameObject.Find((x - n).ToString()));
            Targets.Add(GameObject.Find((x + n).ToString()));
        }
    }
}
