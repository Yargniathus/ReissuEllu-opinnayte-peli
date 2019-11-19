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


    public static int tapaus = 0;

    public static int rdm1 = 0;
    public static int rdm2 = 0;
    public static int rdm3 = 0;

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
        Vector3 pos2 = new Vector3(-10f, 0f, 0f);

        switch (rdm2)
        {
            case 1:
                GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie1.name = "tie1";

                tapaus = 1;

                break;

            case 2:
                GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie2.name = "tie2";
                tapaus = 2;
                apuva = aputie2;
                break;

            case 3:
                GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie3.name = "tie3";
                tapaus = 3;
                apuva = aputie3;
                break;

            case 4:
                GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie4.name = "tie4";
                tapaus = 4;
                apuva = aputie4;
                break;

            case 5:
                GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie5.name = "tie5";
                tapaus = 5;
                apuva = aputie5;
                break;

            case 6:
                GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie6.name = "tie6";
                tapaus = 6;
                apuva = aputie6;
                break;

            case 7:
                GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                aputie7.name = "tie7";
                tapaus = 7;
                apuva = aputie7;
                break;

        }//switch

        tapaus = rdm2;

        existingPositionz.Add(pos2);

        //int rdm1 = Random.Range(1, 8);

        //switch (rdm1)
        //{
        //    case 1:
        //        GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie1.name = "tie1";
        //        tapaus = 1;
        //        break;

        //    case 2:
        //        GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie2.name = "tie2";
        //        tapaus = 2;
        //        apuva = aputie2;
        //        break;

        //    case 3:
        //        GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie3.name = "tie3";
        //        tapaus = 3;
        //        apuva = aputie3;
        //        break;

        //    case 4:
        //        GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie4.name = "tie4";
        //        tapaus = 4;
        //        apuva = aputie4;
        //        break;

        //    case 5:
        //        GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie5.name = "tie5";
        //        tapaus = 5;
        //        apuva = aputie5;
        //        break;

        //    case 6:
        //        GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie6.name = "tie6";
        //        tapaus = 6;
        //        apuva = aputie6;
        //        break;

        //    case 7:
        //        GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
        //        aputie7.name = "tie7";
        //        tapaus = 7;
        //        apuva = aputie7;
        //        break;

        //}//switch

        //tapaus = rdm1;

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
            //    ////if(tapaus==0)
            ////{
            ////    existingPositionz.Clear();
            ////}

            ////POSITION 1

            ////checks if there is already a tile
            //Vector3 pos1 = new Vector3(-10f, 3f, 0f);
            //if (!(existingPositionz.Contains(pos1)))
            //{
            //    //randomizes the tile
            //    int rdm1 = Random.Range(1, 8);

            //    switch (rdm1)
            //    {
            //        case 1:                        
            //            GameObject aputie1 = Instantiate(this.tie1, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie1.name = "tie1";

            //            tapaus = 1;

            //            break;

            //        case 2:
            //            GameObject aputie2 = Instantiate(this.tie2, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie2.name = "tie2";
            //            tapaus = 2;
            //            apuva = aputie2;
            //            break;

            //        case 3:
            //            GameObject aputie3 = Instantiate(this.tie3, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie3.name = "tie3";
            //            tapaus = 3;
            //            apuva = aputie3;
            //            break;

            //        case 4:
            //            GameObject aputie4 = Instantiate(this.tie4, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie4.name = "tie4";
            //            tapaus = 4;
            //            apuva = aputie4;
            //            break;

            //        case 5:
            //            GameObject aputie5 = Instantiate(this.tie5, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie5.name = "tie5";
            //            tapaus = 5;
            //            apuva = aputie5;
            //            break;

            //        case 6:
            //            GameObject aputie6 = Instantiate(this.tie6, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie6.name = "tie6";
            //            tapaus = 6;
            //            apuva = aputie6;
            //            break;

            //        case 7:
            //            GameObject aputie7 = Instantiate(this.tie7, new Vector3(-10f, 3f, 0f), Quaternion.identity);
            //            aputie7.name = "tie7";
            //            tapaus = 7;
            //            apuva = aputie7;
            //            break;

            //    }//switch

            //    existingPositionz.Add(pos1);
            //    tapaus = rdm1;
            //}//if



            //POSITION 2



            //checks if there is already a tile
            Vector3 pos2 = new Vector3(-10f, 0f, 0f);
            if (!(existingPositionz.Contains(pos2)))
            {
                 int rdm2 = Random.Range(1, 8);

                switch (rdm2)
                {
                    case 1:
                        GameObject aputie1 = Instantiate(this.tie1, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie1.name = "tie1";

                        tapaus = 1;

                        break;

                    case 2:
                        GameObject aputie2 = Instantiate(this.tie2, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie2.name = "tie2";
                        tapaus = 2;
                        apuva = aputie2;
                        break;

                    case 3:
                        GameObject aputie3 = Instantiate(this.tie3, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie3.name = "tie3";
                        tapaus = 3;
                        apuva = aputie3;
                        break;

                    case 4:
                        GameObject aputie4 = Instantiate(this.tie4, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie4.name = "tie4";
                        tapaus = 4;
                        apuva = aputie4;
                        break;

                    case 5:
                        GameObject aputie5 = Instantiate(this.tie5, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie5.name = "tie5";
                        tapaus = 5;
                        apuva = aputie5;
                        break;

                    case 6:
                        GameObject aputie6 = Instantiate(this.tie6, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie6.name = "tie6";
                        tapaus = 6;
                        apuva = aputie6;
                        break;

                    case 7:
                        GameObject aputie7 = Instantiate(this.tie7, new Vector3(-9.5f, 0f, 0f), Quaternion.identity);
                        aputie7.name = "tie7";
                        tapaus = 7;
                        apuva = aputie7;
                        break;

                }//switch
                                
                tapaus = rdm2;           

                existingPositionz.Add(pos2);

            }//if


            ////POSITION 3

            
            ////checks if there is already a tile
            //Vector3 pos3 = new Vector3(-10f, -3f, 0f);
            //if (!(existingPositionz.Contains(pos3)))
            //{
            //    int rdm3 = Random.Range(1, 8);

            //    switch (rdm3)
            //    {
            //        case 1:
            //            GameObject aputie1 = Instantiate(this.tie1, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie1.name = "tie1";

            //            break;

            //        case 2:
            //            GameObject aputie2 = Instantiate(this.tie2, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie2.name = "tie2";

            //            break;

            //        case 3:
            //            GameObject aputie3 = Instantiate(this.tie3, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie3.name = "tie3";

            //            break;

            //        case 4:
            //            GameObject aputie4 = Instantiate(this.tie4, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie4.name = "tie4";

            //            break;

            //        case 5:
            //            GameObject aputie5 = Instantiate(this.tie5, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie5.name = "tie5";

            //            break;

            //        case 6:
            //            GameObject aputie6 = Instantiate(this.tie6, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie6.name = "tie6";

            //            break;

            //        case 7:
            //            GameObject aputie7 = Instantiate(this.tie7, new Vector3(-10f, -3f, 0f), Quaternion.identity);
            //            aputie7.name = "tie7";

            //            break;

            //    }//switch
                
            //    existingPositionz.Add(pos3);

            //}//if

            //if (Input.GetKeyDown(KeyCode.Mouse0))
            //{

            //    //pointterinlocaatio
            //    Vector3 xyz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    float x = xyz.x;
            //    float y = xyz.y;
            //    float z = 0;
                
            //    if(x < -8f && x > -12f)
            //    {
            //        if (y < 4.5f && y > 1.5f)
            //        {
            //            sijainti = rdm1;
            //        }//if

            //        if (y < 1.5f && y > -1.5f)
            //        {
            //            sijainti = rdm2;
            //        }//if

            //        if (y < -1.5f && y > -4.5f)
            //        {
            //            sijainti = rdm3;
            //        }//if

            //    }//if          

            //}//if

            ////if(Input.GetKeyDown(KeyCode.O))
            ////{
            ////    switch(sijainti)
            ////    {
            ////        case 1:
            ////            GameObject aputie1 = Instantiate(this.tie1, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie1.name = "tiex";

            ////            break;

            ////        case 2:
            ////            GameObject aputie2 = Instantiate(this.tie2, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie2.name = "tiex";

            ////            break;

            ////        case 3:
            ////            GameObject aputie3 = Instantiate(this.tie3, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie3.name = "tiex";

            ////            break;

            ////        case 4:
            ////            GameObject aputie4 = Instantiate(this.tie4, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie4.name = "tiex";

            ////            break;

            ////        case 5:
            ////            GameObject aputie5 = Instantiate(this.tie5, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie5.name = "tiex";

            ////            break;

            ////        case 6:
            ////            GameObject aputie6 = Instantiate(this.tie6, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie6.name = "tiex";

            ////            break;

            ////        case 7:
            ////            GameObject aputie7 = Instantiate(this.tie7, new Vector3(0f, 0f, 0f), Quaternion.identity);
            ////            aputie7.name = "tiex";

            ////            break;

            ////    }
            ////}


        }//if

    }//update

}//class
