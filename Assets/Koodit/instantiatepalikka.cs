using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatepalikka : MonoBehaviour
{
    public GameObject myPrefab;
    public float xarvo = 1.0F;
    public float yarvo = 1.0F;
    public float x = 1.0F;
    public float y = 1.0F;
    List<Vector3> existingPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (myPrefab != null)
        //{
            myPrefab = Resources.Load("PHRoad") as GameObject;
        //}
        // Mouse1 heittää palikan xarvo yarvo kohtaan
        if (Input.GetKeyDown(KeyCode.LeftControl))
            {

            //pointterinlocaatio
            Vector3 xyz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float x = xyz.x;
            float y = xyz.y;
            float z = 0;
            //y akselin ohjaus
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
            // Instantiate the projectile at the position and rotation of this transform
            Vector3 pos = new Vector3(x, y, z);
            if (!(existingPositions.Contains(pos)))
            {
                Instantiate(myPrefab, new Vector3(x, y, 0), Quaternion.identity);
                existingPositions.Add(pos);
            }
                
            }
        
    }
}
