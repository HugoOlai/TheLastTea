using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatilho : MonoBehaviour
{
    public Rigidbody2D pedra;
    // Start is called before the first frame update
    void Start()
    {
        //pedra = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pedra == null)
        {
            print("RB SUMIU!");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("heroi"))
        {
            Debug.Log("teste de colisão");
            pedra.simulated = true;
        }


    }
}
