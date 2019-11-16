using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoKoodi : MonoBehaviour
{
        
    // Start is called before the first frame update
    void Start()
    {
        
    } //start


    // Update is called once per frame
    void Update()
    {
        //driving the car
        //d = 1, w = 2, a = 3, s = 4
        
        if (Input.GetKey(KeyCode.W))
        {         
                       
            this.GetComponent<Transform>().Translate(Time.deltaTime * 0f, 0.075f, 0f);
            
        }//if

        if (Input.GetKey(KeyCode.S))
        {

            this.GetComponent<Transform>().Translate(Time.deltaTime * 0f, -0.025f, 0f);

        }//if

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            this.GetComponent<Transform>().Rotate(0f, 0f, 90f);

        }//if



        if (Input.GetKeyDown(KeyCode.D))
        {
            
            this.GetComponent<Transform>().Rotate(0f, 0f, -90f);
            
        }//if
        
        
    } //update

}//class
