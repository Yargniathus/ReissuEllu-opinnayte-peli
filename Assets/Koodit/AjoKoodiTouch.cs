using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AjoKoodiTouch : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    } //start




    // Update is called once per frame
    void Update()
    {

        Vector3 aali = GameObject.FindGameObjectWithTag("Pokaali").transform.position;
        Vector3 xyz = this.transform.position;
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
        //driving the car
        //d = 1, w = 2, a = 3, s = 4
        Vector3 pos = new Vector3(x, y, z);
        if (pos == aali)
        {
            SceneManager.LoadScene("end");
        }
        if (instantiatepalikka.existingPositions.Contains(pos))
        {
            //kursorilokaatio
            Vector3 hiiri = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float hiirix = hiiri.x;
            float hiiriy = hiiri.y;
            float hiiriz = 0;
            
            if (hiiriy < -5 && hiiriy > -7) {
                //ylös
                if (Input.GetKey(KeyCode.Mouse0) && (hiirix>-2) && (hiirix<0))
                {
                    Vector3 eulerRotation = transform.rotation.eulerAngles;
                    transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);
                    this.GetComponent<Transform>().Translate(0f, Time.deltaTime * 1.6f, 0f);

                }//alas

                if (Input.GetKey(KeyCode.Mouse0) && (hiirix > 0) && (hiirix < 2))
                {
                    Vector3 eulerRotation = transform.rotation.eulerAngles;
                    transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 180);
                   this.GetComponent<Transform>().Translate(0f, Time.deltaTime * 1.6f, 0f);


                }//vasen

                if (Input.GetKey(KeyCode.Mouse0) && (hiirix > -4) && (hiirix < -2))
                {
                    Vector3 eulerRotation = transform.rotation.eulerAngles;
                    transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 90);
                    this.GetComponent<Transform>().Translate(0f, Time.deltaTime * 1.6f, 0f);

                }//oikea



                if (Input.GetKey(KeyCode.Mouse0) && (hiirix > 2) && (hiirix < 4))
                {
                    Vector3 eulerRotation = transform.rotation.eulerAngles;
                    transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 270);
                    this.GetComponent<Transform>().Translate(0f, Time.deltaTime * 1.6f, 0f);

                }

                //if

            }
        } //update

    }
}//class
