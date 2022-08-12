using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorPB : MonoBehaviour
{
    public WonGame Script;
    public bool GameOverr = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Script.balls == 0f)
        {
            GameOverr = true;
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        
        
           
        if(GameOverr == false)
        {
            SceneManager.LoadScene(4);
        }
        else if(GameOverr == true)
        {

        }
        
       
        
    }
}
