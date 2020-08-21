using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ohje1Seuraava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void seuraava1Painettu()
    {
        SceneManager.LoadScene("Ohje 2");
    }

    public void seuraava2Painettu()
    {
        SceneManager.LoadScene("Ohje 3");
    }

}
