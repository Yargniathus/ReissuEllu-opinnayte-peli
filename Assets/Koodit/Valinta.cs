using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valinta : MonoBehaviour
{
    public static bool ylempi = false;
    public static bool alempi = false;

    public GameObject slaideri = null;

    // Start is called before the first frame update
    void Start()
    {
        slaideri = GameObject.Find("Slider");
        alempi = true;
    }

    // Update is called once per frame
    void Update()
    {
        //determines which tile to use
        if (slaideri.GetComponent<Slider>().value==1)
        {
            ylempi = true;
            alempi = false;
        }

        if(slaideri.GetComponent<Slider>().value == 0)
        {
            alempi = true;
            ylempi = false;
        }

        //Debug.Log(ylempi);
        //Debug.Log(alempi);
    }
}
