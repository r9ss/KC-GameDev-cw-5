using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWIn : MonoBehaviour
{
   [SerializeField] Transform[] Posistions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;
    public WonGame Script;
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Posistions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Script.balls == 0f)
        {
            MoveGameObject();
            
        }
        else 
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
