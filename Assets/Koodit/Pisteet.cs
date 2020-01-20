using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pisteet : MonoBehaviour
{
    // Start is called before the first frame update
    public static float pisteet = 100f;
    private GameObject pistetext = null;
    void Start()
    {
        this.pistetext = GameObject.Find("pisteText");
    }

    // Update is called once per frame
    void Update()
    {


        this.pistetext.GetComponent<Text>().text = pisteet.ToString("0");
        


        //update
    }
}
