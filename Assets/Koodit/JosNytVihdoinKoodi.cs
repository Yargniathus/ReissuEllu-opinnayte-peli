using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JosNytVihdoinKoodi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }//start

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Transform>().position.x < -8 && TileSpawn.tapaus==0)
        {
            Destroy(this.gameObject);

        }//if

    }//update
}
