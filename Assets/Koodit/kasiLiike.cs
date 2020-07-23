using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class käsiLiike : MonoBehaviour
{
    public float aika = 5;    
    int suunta = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                      
        this.aika -= (Time.deltaTime * 2);


        if (suunta == 1)
        {
            this.GetComponent<Transform>().Translate(Time.deltaTime * 1f, 0f, 0f);
            if (aika < 0)
            {
                suunta = 2;
                aika = 5;
            }//if
        }//if

        if (suunta == 2)
        {
            this.GetComponent<Transform>().Translate(Time.deltaTime * -1f, 0f, 0f);
            if (aika < 0)
            {
                suunta = 1;
                aika = 5;
            }//if
        }//if
    }//if

       







}

