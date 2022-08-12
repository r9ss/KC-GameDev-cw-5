using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MapSelect : MonoBehaviour
{

    public bool Basketball = true;
    public bool Donut = false;
    public bool poolBall = false;
    public bool Redball = false;
    public float pressesdCount = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddNumber()
    {
        pressesdCount +=1f;

    }



    public void BasketballMap()
    {
        if(Basketball == true)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void DonutMap()
    {
        if(Basketball == true)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void poolBallMap()
    {
        if(Basketball == true)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void RedballMap()
    {
        if(Basketball == true)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void MapSelectBool()
    {
        if(pressesdCount == 0)
        {
            BasketballMap();
        }
        else if(pressesdCount == 1)
        {
            DonutMap();
        }
        else if(pressesdCount == 2)
        {
            poolBallMap();
        }
        else if(pressesdCount == 3)
        {
            RedballMap();
        }
         else if(pressesdCount == 4)
        {
            BasketballMap();
        }
        else if(pressesdCount == 5)
        {
            DonutMap();
        } 
        else if(pressesdCount == 6)
        {
            poolBallMap();
        }
        else if(pressesdCount == 7)
        {
            RedballMap();
        }
         else if(pressesdCount == 8)
        {
            BasketballMap();
        }
        else if(pressesdCount == 9)
        {
            DonutMap();
        } 
        else if(pressesdCount == 10f)
        {
            poolBallMap();
        }
        else if(pressesdCount == 11f)
        {
            RedballMap();
        }
        else if(pressesdCount == 12f)
        {
            BasketballMap();
        }
        else if(pressesdCount == 13f)
        {
            DonutMap();
        } 
        else if(pressesdCount == 14f)
        {
            poolBallMap();
        }
        else if(pressesdCount == 15f)
        {
            RedballMap();
        }
    }

}
