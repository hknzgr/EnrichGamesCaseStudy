using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlotController : MonoBehaviour
{
    public bool clicked;
    static int counter;
    static List<GameObject> slots = new List<GameObject>();
    List<int> target = new List<int>();



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ButtonCliked()
    {
        clicked = true;
    }

    public void TicToc()
    {
        if (counter>=2)
        {
            foreach (var item in slots)
            {
                item.GetComponent<SlotController>().clicked = false;
                item.GetComponent<Image>().sprite = null;
                
                
                //slots.Clear();
            }
            this.gameObject.GetComponent<Image>().sprite = null;
            this.GetComponent<SlotController>().clicked = false;
            slots.Clear();
            counter = 0;
        }
    }

    public void Controller4()
    {
        GameObject x = this.gameObject;
        GameObject Left = GameObject.Find((int.Parse(this.name) - 1).ToString());
        GameObject Right = GameObject.Find((int.Parse(this.name) + 1).ToString());
        GameObject Up = (GameObject.Find((int.Parse(this.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
        GameObject Down = (GameObject.Find((int.Parse(this.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));

        if (int.Parse(this.name) % GameObject.Find("GameController").GetComponent<GameController>().n==0)
        {
            if (Left.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Left))
                {
                    counter++;
                    slots.Add(Left);
                }

                if (GameObject.Find((int.Parse(Left.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) - 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }
            
            if (Down.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Down))
                {
                    counter++;
                    slots.Add(Down);
                }
                
                if (GameObject.Find((int.Parse(Down.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) - 1).ToString()));
                    }
                    
                }
                if (GameObject.Find((int.Parse(Down.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + 1).ToString()));
                    }
                    
                }
                if ((GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }
                    
                }
            }
        }else if (int.Parse(this.name) % GameObject.Find("GameController").GetComponent<GameController>().n == 1)
        {
            if (Right.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Right))
                {
                    counter++;
                    slots.Add(Right);
                }
                if (GameObject.Find((int.Parse(Right.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }
                }
            }

            if (Up.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Up))
                {
                    counter++;
                    slots.Add(Up);
                }

                if (GameObject.Find((int.Parse(Up.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - 1).ToString()));
                    }

                }
                if (GameObject.Find((int.Parse(Up.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }


            if (Up.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Up))
                {
                    counter++;
                    slots.Add(Up);
                }

                if (GameObject.Find((int.Parse(Up.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - 1).ToString()));
                    }

                }
                if (GameObject.Find((int.Parse(Up.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }

            if (Down.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Down))
                {
                    counter++;
                    slots.Add(Down);
                }

                if (GameObject.Find((int.Parse(Down.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) - 1).ToString()));
                    }

                }
                if (GameObject.Find((int.Parse(Down.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }
        }
        else
        {
            if (Right.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Right))
                {
                    counter++;
                    slots.Add(Right);
                }
                if (GameObject.Find((int.Parse(Right.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Right.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }
                }
            }
            if (Left.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Left))
                {
                    counter++;
                    slots.Add(Left);
                }

                if (GameObject.Find((int.Parse(Left.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) - 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Left.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }

            if (Up.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Up))
                {
                    counter++;
                    slots.Add(Up);
                }

                if (GameObject.Find((int.Parse(Up.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - 1).ToString()));
                    }

                }
                if (GameObject.Find((int.Parse(Up.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Up.name) - GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }

            if (Down.GetComponent<SlotController>().clicked == true)
            {
                if (!slots.Contains(Down))
                {
                    counter++;
                    slots.Add(Down);
                }

                if (GameObject.Find((int.Parse(Down.name) - 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) - 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) - 1).ToString()));
                    }

                }
                if (GameObject.Find((int.Parse(Down.name) + 1).ToString()).GetComponent<SlotController>().clicked == true)
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + 1).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + 1).ToString()));
                    }

                }
                if ((GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                {
                    if (!slots.Contains(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString())))
                    {
                        counter++;
                        slots.Add(GameObject.Find((int.Parse(Down.name) + GameObject.Find("GameController").GetComponent<GameController>().n).ToString()));
                    }

                }
            }
        }


        Debug.Log(counter);
        TicToc();

        
    }


    public void Controller2()
    {
        int x = int.Parse(this.name);
        int n = GameObject.Find("GameController").GetComponent<GameController>().n;

        int[] target = {(x-(2*n)) , (x-n-1), (x-n), (x-n+1), (x-2), (x-1), (x+1) , (x+2), (x+n-1), (x+n), (x+n+1) , (x+(2*n))};

        foreach (var item in target)
        {
            GameObject controlTarget = GameObject.Find(item.ToString());
            if (controlTarget.GetComponent<SlotController>().clicked==true)
            {
                slots.Add(controlTarget);
            }

        }

    }

    public void Controller()
    {
        int x = int.Parse(this.name);
        int n = GameObject.Find("GameController").GetComponent<GameController>().n;
        int left= (x - 1);
        int right= (x + 1);
        int up= (x - n);
        int down= (x + n);
        

        if (x%n==1)
        {
            target.Add(right);
            target.Add(up);
            target.Add(down);
        }
        else if (x%n==0)
        {
            target.Add(left);
            target.Add(up);
            target.Add(down);
        }
        else
        {
            target.Add(left);
            target.Add(right);
            target.Add(up);
            target.Add(down);
        }

        foreach (var item in target)
        {
            try
            {
                GameObject controlTarget = GameObject.Find(item.ToString());
                if (controlTarget.GetComponent<SlotController>().clicked == true)
                {
                    counter++;
                    slots.Add(controlTarget);
                    slots.Add(this.gameObject);
                    
                }
            }
            catch
            {
                print("There is no such object!");
            }
            
           
        }

        TicToc();

    }
}
