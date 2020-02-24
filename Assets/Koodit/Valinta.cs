using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Valinta : MonoBehaviour
{
    public static bool ylempi = false;
    public static bool alempi = false;

    //public GameObject slaideri = null;
    public GameObject ylempibox = null;
    public GameObject alempibox = null;
    private SpriteRenderer ylempiorder;
    private SpriteRenderer alempiorder;

    // Start is called before the first frame update
    void Start()
    {
        //slaideri = GameObject.Find("Slider");
        ylempibox = GameObject.Find("ylempibox");
        alempibox = GameObject.Find("alempibox");
        ylempiorder = ylempibox.GetComponent<SpriteRenderer>();
        alempiorder = alempibox.GetComponent<SpriteRenderer>();
        ylempi = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 xyz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float x = xyz.x;
            float y = xyz.y;
            float z = 0;

            //determines which tile to use
            //if (slaideri.GetComponent<Slider>().value==1)
            if ((x > -10.5 && x < -8.5)&&(y < 2 && y > 0))
            {
                ylempi = true;
                alempi = false;
                ylempiorder.sortingOrder = 2;
                alempiorder.sortingOrder = 0;
                
            }

            //if (slaideri.GetComponent<Slider>().value == 0)
            if ((x > -10.5 && x < -8.5) && (y < -1.5 && y > -3.5))
            {
                alempi = true;
                ylempi = false;
                alempiorder.sortingOrder = 2;
                ylempiorder.sortingOrder = 0;
            }
        }
        //Debug.Log(ylempi);
        //Debug.Log(alempi);
    }
}
