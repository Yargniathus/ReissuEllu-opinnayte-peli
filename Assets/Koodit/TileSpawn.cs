using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public GameObject pojka = null;
    public GameObject pallo = null;
    public GameObject tie = null;

    // Start is called before the first frame update
    void Start()
    {
        pojka = GameObject.Find("poika");
        pallo = GameObject.Find("volyball_2");
        tie = GameObject.Find("PHRoad");

    }//start

    // Update is called once per frame
    void Update()
    {    

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            int rdm = Random.Range(1, 4);

            switch (rdm)
            {
                case 1:
                    GameObject apupojka = Instantiate(this.pojka, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                    apupojka.name = "poiiiikaa";
                    break;

                case 2:
                    GameObject apupallo = Instantiate(this.pallo, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                    apupallo.name = "ballo";
                    break;

                case 3:
                    GameObject aputie = Instantiate(this.tie, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                    aputie.name = "die";
                    break;

            }//switch

        }//if

    }//update

}//class
