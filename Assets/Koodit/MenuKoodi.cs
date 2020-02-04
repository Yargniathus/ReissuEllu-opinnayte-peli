using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuKoodi : MonoBehaviour
{
        
    public GameObject MenuTaulu = null;

    // Start is called before the first frame update
    void Start()
    {
               

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NappiPainettu()
    {
        GameObject apumenu = Instantiate(this.MenuTaulu, new Vector3(149, 197, 0), Quaternion.identity);
        apumenu.name = "menu";
    }


   
}
