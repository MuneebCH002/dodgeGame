using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float movespeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
    printinstruction();
    }

    // Update is called once per frame
    void Update()
    {
        Moveplayer();

    }
    void printinstruction()
    {
       // Debug.Log("Start game");
        //Debug.Log("Control player by arroe key");
    }
    void Moveplayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue, 0, zvalue);
        
    }
    
}
   
