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

    public bool apuva = false;

    public bool ylempi = false;
    public bool alempi = false;


    public static int tapaus = 0;
    public static int tapaus2 = 0;

    public static int rdm1 = 0;
    public static int rdm2 = 0;

    public int sijainti = 0;
    public static  GameObject klikattu = null;


    public float xarvo = 1.0F;
    public float yarvo = 1.0F;
    public float x = 1.0F;
    public float y = 1.0F;
   

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

        //Ensimmäinen palikka
        int rdm2 = Random.Range(1, 8);
        Vector3 pos2 = new Vector3(-10f, 1.3f, 0f);

        switch (rdm2)
        {
            case 1:
                GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie1.name = "tie1";
                apuva = aputie1;
                tapaus2 = 1;

                break;

            case 2:
                GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie2.name = "tie2";
                tapaus2 = 2;
                apuva = aputie2;
                break;

            case 3:
                GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie3.name = "tie3";
                tapaus2 = 3;
                apuva = aputie3;
                break;

            case 4:
                GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie4.name = "tie4";
                tapaus2 = 4;
                apuva = aputie4;
                break;

            case 5:
                GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie5.name = "tie5";
                tapaus2 = 5;
                apuva = aputie5;
                break;

            case 6:
                GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie6.name = "tie6";
                tapaus2 = 6;
                apuva = aputie6;
                break;

            case 7:
                GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                aputie7.name = "tie7";
                tapaus2 = 7;
                apuva = aputie7;
                break;

        }//switch


        //second tile spawn (can not be selected yet)
        int rdm1 = Random.Range(1, 8);

        Vector3 pos1 = new Vector3(-10f, -1.3f, 0f);

        switch (rdm1)
        {
            case 1:
                GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie1.name = "tie1";
                apuva = aputie1;
                tapaus = 1;

                break;

            case 2:
                GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie2.name = "tie2";
                tapaus = 2;
                apuva = aputie2;
                break;

            case 3:
                GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie3.name = "tie3";
                tapaus = 3;
                apuva = aputie3;
                break;

            case 4:
                GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie4.name = "tie4";
                tapaus = 4;
                apuva = aputie4;
                break;

            case 5:
                GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie5.name = "tie5";
                tapaus = 5;
                apuva = aputie5;
                break;

            case 6:
                GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie6.name = "tie6";
                tapaus = 6;
                apuva = aputie6;
                break;

            case 7:
                GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                aputie7.name = "tie7";
                tapaus = 7;
                apuva = aputie7;
                break;

        }//switch



    }//start


    // Update is called once per frame
    void Update()
    {
        

        if (tapaus == 0)
        {
            existingPositionz.Clear();

        }
                

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            
            //hiiren position tarkistus huijaamisen estämiseksi
            Vector3 xyzhiiri = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                float xhiiri = xyzhiiri.x;
                float yhiiri = xyzhiiri.y;
                float zhiiri = 0;

            //checks if there is already a tile 
            Vector3 pos2 = new Vector3(-10f, 1.3f, 0f);
            Vector3 pos1 = new Vector3(-10f, -1.3f, 0f);

            //also if the click is on the grid
            if (!(existingPositionz.Contains(pos2)) && !(xhiiri > 8 || xhiiri < -8 || yhiiri > 5 || yhiiri < -5) && instantiatepalikka.tilePlaced)
            {


                //TÄLLÄ HETKELLÄ SPAWNAA PELKÄSTÄÄN PALIKKAA 1, TESTITARKOITUKSEKSI
                //upper tile randomization
                int rdm2 = Random.Range(1, 8);
                //lower tile randomization
                int rdm1 = Random.Range(1, 8);


                switch (rdm2)
                {
                    case 1:
                        GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie1.name = "tie1";
                        apuva = aputie1;
                        tapaus2 = 1;

                        break;

                    case 2:
                        GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie2.name = "tie2";
                        tapaus2 = 2;
                        apuva = aputie2;
                        break;

                    case 3:
                        GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie3.name = "tie3";
                        tapaus2 = 3;
                        apuva = aputie3;
                        break;

                    case 4:
                        GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie4.name = "tie4";
                        tapaus2 = 4;
                        apuva = aputie4;
                        break;

                    case 5:
                        GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie5.name = "tie5";
                        tapaus2 = 5;
                        apuva = aputie5;
                        break;

                    case 6:
                        GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie6.name = "tie6";
                        tapaus2 = 6;
                        apuva = aputie6;
                        break;

                    case 7:
                        GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, 1f, 0f), Quaternion.identity);
                        aputie7.name = "tie7";
                        tapaus2 = 7;
                        apuva = aputie7;
                        break;

                }//switch
                               
                
                //TÄLLÄ HETKELLÄ SPAWNAA PELKÄSTÄÄN PALIKKAA 2, TESTITARKOITUKSEKSI
                //lower tile spawn on click
                switch (rdm1)
                {
                    case 1:
                        GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie1.name = "tie1";
                        apuva = aputie1;
                        tapaus = 1;

                        break;

                    case 2:
                        GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie2.name = "tie2";
                        tapaus = 2;
                        apuva = aputie2;
                        break;

                    case 3:
                        GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie3.name = "tie3";
                        tapaus = 3;
                        apuva = aputie3;
                        break;

                    case 4:
                        GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie4.name = "tie4";
                        tapaus = 4;
                        apuva = aputie4;
                        break;

                    case 5:
                        GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie5.name = "tie5";
                        tapaus = 5;
                        apuva = aputie5;
                        break;

                    case 6:
                        GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie6.name = "tie6";
                        tapaus = 6;
                        apuva = aputie6;
                        break;

                    case 7:
                        GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, -2.5f, 0f), Quaternion.identity);
                        aputie7.name = "tie7";
                        tapaus = 7;
                        apuva = aputie7;
                        break;

                }//switch
                                             
                
            }
                        
            
        } //mouse0 if

    }//update

}
