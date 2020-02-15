using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhjeKoodi : MonoBehaviour
{
    public GameObject ohje = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void suljePainettu()
    {
        ohje = GameObject.Find("ohjeet");
        GameObject.Destroy(ohje);
    }
}
