using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViperMove : MonoBehaviour

{


    public float speed;


    // Start is called before the first frame update
    void Start()
    {

        speed = 15f;


    }

    // Update is called once per frame
    void Update()
    {

        MovimientoViper();
    }


    void MovimientoViper()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

         
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
         

         
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
         


    }
}


