using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketbll : MonoBehaviour
{
   
  public bool GameGoing = true;
    Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(GameGoing == true)
        {
            
            Destroy (gameObject);
        }
        else if (GameGoing == false)
        {

        }
        
    }
}
