using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public GameObject tie1 = null;
    public GameObject tie2 = null;
    public GameObject tie3 = null;
    public GameObject tie4 = null;
    public GameObject tie5 = null;
    public GameObject tie6 = null;
    public GameObject tie7 = null;

    List<Vector3> existingPositionz = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        tie1 = GameObject.Find("Tie_horzi");
        tie2 = GameObject.Find("Tie_OA");
        tie3 = GameObject.Find("Tie_OY");
        tie4 = GameObject.Find("Tie_risteys");
        tie5 = GameObject.Find("Tie_VA");
        tie6 = GameObject.Find("Tie_verti");
        tie7 = GameObject.Find("Tie_VY");

    }//start

    // Update is called once per frame
    void Update()
    {    

        if (Input.GetKeyDown(KeyCode.RightControl))
        {

            //POSITION 1

            //randomizes the tile
            int rdm1 = Random.Range(1, 8);

            //checks if there is already a tile
            Vector3 pos1 = new Vector3(-10f, 3f, 0f);
            if (!(existingPositionz.Contains(pos1)))
            {
               
                switch (rdm1)
                {
                    case 1:
                        GameObject aputie1 = Instantiate(this.tie1, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie1.name = "tie1";

                        break;

                    case 2:
                        GameObject aputie2 = Instantiate(this.tie2, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie2.name = "tie2";

                        break;

                    case 3:
                        GameObject aputie3 = Instantiate(this.tie3, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie3.name = "tie3";

                        break;

                    case 4:
                        GameObject aputie4 = Instantiate(this.tie4, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie4.name = "tie4";

                        break;

                    case 5:
                        GameObject aputie5 = Instantiate(this.tie5, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie5.name = "tie5";

                        break;

                    case 6:
                        GameObject aputie6 = Instantiate(this.tie6, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie6.name = "tie6";

                        break;

                    case 7:
                        GameObject aputie7 = Instantiate(this.tie7, new Vector3(-10f, 3f, 0f), Quaternion.identity);
                        aputie7.name = "tie7";

                        break;

                }//switch

                existingPositionz.Add(pos1);
            }//if



            //POSITION 2

            int rdm2 = Random.Range(1, 8);

            //checks if there is already a tile
            Vector3 pos2 = new Vector3(-10f, 0f, 0f);
            if (!(existingPositionz.Contains(pos2)))
            {
                    switch (rdm2)
                    {
                        case 1:
                            GameObject aputie1 = Instantiate(this.tie1, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie1.name = "tie1";

                            break;

                        case 2:
                            GameObject aputie2 = Instantiate(this.tie2, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie2.name = "tie2";

                            break;

                        case 3:
                            GameObject aputie3 = Instantiate(this.tie3, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie3.name = "tie3";

                            break;

                        case 4:
                            GameObject aputie4 = Instantiate(this.tie4, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie4.name = "tie4";

                            break;

                        case 5:
                            GameObject aputie5 = Instantiate(this.tie5, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie5.name = "tie5";

                            break;

                        case 6:
                            GameObject aputie6 = Instantiate(this.tie6, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie6.name = "tie6";

                            break;

                        case 7:
                            GameObject aputie7 = Instantiate(this.tie7, new Vector3(-10f, 0f, 0f), Quaternion.identity);
                            aputie7.name = "tie7";

                            break;

                    }//switch

                existingPositionz.Add(pos2);
            }//if


            //POSITION 3

            int rdm3 = Random.Range(1, 8);
            //checks if there is already a tile
            Vector3 pos3 = new Vector3(-10f, -3f, 0f);
            if (!(existingPositionz.Contains(pos3)))
            {
                    switch (rdm3)
                    {
                        case 1:
                            GameObject aputie1 = Instantiate(this.tie1, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie1.name = "tie1";

                            break;

                        case 2:
                            GameObject aputie2 = Instantiate(this.tie2, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie2.name = "tie2";

                            break;

                        case 3:
                            GameObject aputie3 = Instantiate(this.tie3, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie3.name = "tie3";

                            break;

                        case 4:
                            GameObject aputie4 = Instantiate(this.tie4, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie4.name = "tie4";

                            break;

                        case 5:
                            GameObject aputie5 = Instantiate(this.tie5, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie5.name = "tie5";

                            break;

                        case 6:
                            GameObject aputie6 = Instantiate(this.tie6, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie6.name = "tie6";

                            break;

                        case 7:
                            GameObject aputie7 = Instantiate(this.tie7, new Vector3(-10f, -3f, 0f), Quaternion.identity);
                            aputie7.name = "tie7";

                            break;

                    }//switch

                existingPositionz.Add(pos3);
            }//if

        }//if

    }//update

}//class
