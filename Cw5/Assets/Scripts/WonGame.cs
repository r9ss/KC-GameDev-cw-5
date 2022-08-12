using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonGame : MonoBehaviour
{   
    bool rplaySound = true;
    public float balls =6;
    public WInSfxx sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(balls == 0f)
        {
            DoOnce();
            
        }
    }

    public void DoOnce()
    {
        if(rplaySound == true)
        {
            rplaySound = false;
            sfx.PlaySoundd = true;
        }
        else
        {
            
        }
    }
}
