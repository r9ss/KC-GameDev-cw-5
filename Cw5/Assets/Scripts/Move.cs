using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   [SerializeField] Transform[] Posistions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;
    public bool moveBall = true;
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Posistions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(moveBall == true)
        {
            MoveGameObject();
            
        }
        else if(moveBall == false)
        {

        }
    }
    void MoveGameObject()
    {if (transform.position == NextPos.position)
    {
        NextPosIndex++;
        if(NextPosIndex >= Posistions.Length)
        {
            NextPosIndex = 0;
        }
        NextPos = Posistions[NextPosIndex];

    }
    else 
    {
        transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
    }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(7f);
        Destroy (gameObject);


    }
    
    
    }
