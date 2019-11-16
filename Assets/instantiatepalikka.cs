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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (myPrefab != null)
        //{
            myPrefab = Resources.Load("phroad") as GameObject;
        //}
        // Mouse1 heittää palikan xarvo yarvo kohtaan
        if (Input.GetKeyDown(KeyCode.LeftControl))
            {

            //pointterinlocaatio
            Vector3 xyz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float x = xyz.x;
            float y = xyz.y;
            // Instantiate the projectile at the position and rotation of this transform

            Instantiate(myPrefab, new Vector3(x, y, 0), Quaternion.identity);

                
            }
        
    }
}
