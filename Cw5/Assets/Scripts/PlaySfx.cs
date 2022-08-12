using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySfx : MonoBehaviour
{   
   public bool PlaySound = false;
   public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlaySound == true)
        {
            PlaySound = false;
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
}
