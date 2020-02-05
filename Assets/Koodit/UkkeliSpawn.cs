using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UkkeliSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject k1 = null;
    void Start()
    {
        int ukkomaara = 0;

        while (ukkomaara < 4)
        {
            float[] xnumbers = new float[] { -7f, -5f, -3f, -1f, 1f, 3f, 5f };
            float[] ynumbers = new float[] { -2f, 0f, 2f, 4f };
            int xrandomIndex = Random.Range(0, 7);
            int yrandomIndex = Random.Range(0, 4);
            float ukkelix = xnumbers[xrandomIndex];
            float ukkeliy = ynumbers[yrandomIndex];

            //instantioi prefab
            GameObject apu = Instantiate(this.k1,
                           new Vector3(ukkelix, ukkeliy, 0f),
                           Quaternion.identity);
            apu.name = "X1";
            ukkomaara += 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
