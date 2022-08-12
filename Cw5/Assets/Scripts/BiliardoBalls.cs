using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BiliardoBalls : MonoBehaviour
{
    
    public WonGame ballsLeft;
    public bool GameGoing = true;
    Rigidbody2D RB;
    public PlaySfx Script;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.isKinematic = true;
       
    }

    // Update is called once per frame
    void Update()
    {
       if(ballsLeft.balls == 0f)
       {
        GameGoing = false;
        isKinematicF();
       }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(GameGoing == true)
        {
            
            ballsLeft.balls -=1;
            Script.PlaySound = true;
            Destroy (gameObject);
        }
        else if (GameGoing == false)
        {

        }
        
    }

    public void isKinematicF()
    {
        RB.isKinematic = false;
    }
}
