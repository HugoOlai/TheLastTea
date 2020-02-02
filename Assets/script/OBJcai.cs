using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJcai : gatilho
{
    private bool 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ativaTrigger == true)
        {
            Debug.Log(ativaTrigger);
            down(ativaTrigger);
        }   
            

        
    }

    public void down(bool e)
    {
        Debug.Log("estou no down");
        this.gameObject.GetComponent<Rigidbody2D>().simulated = true;
    }
}
