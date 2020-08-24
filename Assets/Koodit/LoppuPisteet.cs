using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoppuPisteet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float r1 = PlayerPrefs.GetFloat("finalPoints");
        GameObject.Find("loppuPisteet").GetComponent<Text>().text = ("PISTEET: " + r1.ToString("0"));
                   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
