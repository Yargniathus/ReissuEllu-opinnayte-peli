using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatepalikka : MonoBehaviour
{
    public GameObject myPrefab;
    public float xarvo = 1.0F;
    public float yarvo = 1.0F;
    public static float x = 1.0F;
    public static float y = 1.0F;
    public static float z = 0F;
    public static bool tilePlaced;
    public static List<Vector3> existingPositions = new List<Vector3>();

    public bool ylempi = false;
    public bool alempi = false;



    public GameObject tie1 = null;
    public GameObject tie2 = null;
    public GameObject tie3 = null;
    public GameObject tie4 = null;
    public GameObject tie5 = null;
    public GameObject tie6 = null;
    public GameObject tie7 = null;


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

    }

    // Update is called once per frame
    void Update()
    {
    
        // Mouse1 heittää palikan xarvo yarvo kohtaan
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            tilePlaced = false;

            //pointterinlocaatio
            Vector3 xyz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            x = xyz.x;
            y = xyz.y;
            
            
            if (y < 5 && y > 3)
                {
                y = 4;
                }
            if (y < 3 && y > 1)
            {
                y = 2;
            }
            if (y < 1 && y > -1)
            {
                y = 0;
            }
            if (y < -1 && y > -3)
            {
                y = -2;
            }
            if (y < -3 && y > -5)
            {
                y = -4;
            }
            //x akselin ohjaus
            if (x > -8 && x < -6)
            {
                x = -7;
            }
            if (x > -6 && x < -4)
            {
                x = -5;
            }
            if (x > -4 && x < -2)
            {
                x = -3;
            }
            if (x > -2 && x < 0)
            {
                x = -1;
            }
            if (x > 0 && x < 2)
            {
                x = 1;
            }
            if (x > 2 && x < 4)
            {
                x = 3;
            }
            if (x > 4 && x < 6)
            {
                x = 5;
            }
            if (x > 6 && x < 8)
            {
                x = 7;
            }
            
            Vector3 pos = new Vector3(x, y, z);
            if (!(existingPositions.Contains(pos)) && !(x>8 || x<-8 || y>5 || y<-5))
            {
                if (Valinta.ylempi == true)
                {
                    switch (TileSpawn.tapaus2)
                    {
                        case 1:
                            GameObject aputie1 = Instantiate(this.tie1, new Vector3(x, y, 0), Quaternion.identity);
                            aputie1.name = "tie1";
                            //pisteiden vähennys
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 2:
                            GameObject aputie2 = Instantiate(this.tie2, new Vector3(x, y, 0), Quaternion.identity);
                            aputie2.name = "tie2";
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 3:
                            GameObject aputie3 = Instantiate(this.tie3, new Vector3(x, y, 0), Quaternion.identity);
                            aputie3.name = "tie3";
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 4:
                            GameObject aputie4 = Instantiate(this.tie4, new Vector3(x, y, 0), Quaternion.identity);
                            aputie4.name = "tie4";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 5:
                            GameObject aputie5 = Instantiate(this.tie5, new Vector3(x, y, 0), Quaternion.identity);
                            aputie5.name = "tie5";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 6:
                            GameObject aputie6 = Instantiate(this.tie6, new Vector3(x, y, 0), Quaternion.identity);
                            aputie6.name = "tie6";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 7:
                            GameObject aputie7 = Instantiate(this.tie7, new Vector3(x, y, 0), Quaternion.identity);
                            aputie7.name = "tie7";
                            Pisteet.pisteet -= 2.5f;
                            break;

                    }
                    existingPositions.Add(pos);
                    tilePlaced = true;
                } 


                if (Valinta.alempi == true)
                {
                    switch (TileSpawn.tapaus)
                    {
                        case 1:
                            GameObject aputie1 = Instantiate(this.tie1, new Vector3(x, y, 0), Quaternion.identity);
                            aputie1.name = "tie1";
                            //pisteiden vähennys
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 2:
                            GameObject aputie2 = Instantiate(this.tie2, new Vector3(x, y, 0), Quaternion.identity);
                            aputie2.name = "tie2";
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 3:
                            GameObject aputie3 = Instantiate(this.tie3, new Vector3(x, y, 0), Quaternion.identity);
                            aputie3.name = "tie3";
                            Pisteet.pisteet -= 2.5f;

                            break;

                        case 4:
                            GameObject aputie4 = Instantiate(this.tie4, new Vector3(x, y, 0), Quaternion.identity);
                            aputie4.name = "tie4";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 5:
                            GameObject aputie5 = Instantiate(this.tie5, new Vector3(x, y, 0), Quaternion.identity);
                            aputie5.name = "tie5";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 6:
                            GameObject aputie6 = Instantiate(this.tie6, new Vector3(x, y, 0), Quaternion.identity);
                            aputie6.name = "tie6";
                            Pisteet.pisteet -= 2.5f;
                            break;

                        case 7:
                            GameObject aputie7 = Instantiate(this.tie7, new Vector3(x, y, 0), Quaternion.identity);
                            aputie7.name = "tie7";
                            Pisteet.pisteet -= 2.5f;
                            break;

                    }
                    existingPositions.Add(pos);
                    tilePlaced = true;

                }


                TileSpawn.tapaus = 0;
            }

            

        }
        
    }
}
