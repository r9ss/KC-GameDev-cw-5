using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WInSfxx : MonoBehaviour
{
    
    public WonGame Win;
    public AudioSource audioDataa;
    public bool PlaySoundd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlaySoundd == true)
        {
            PlaySoundd = false;
            audioDataa = GetComponent<AudioSource>();
            audioDataa.Play(0);
            
            
        }

        
    }

    void playWinSfx()
    {
        audioDataa = GetComponent<AudioSource>();
            audioDataa.Play(0);
    }
}
