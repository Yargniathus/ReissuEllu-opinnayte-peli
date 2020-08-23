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

    public void edellinen2Painettu()
    {
        SceneManager.LoadScene("OhjeSceneNew");
    }

    public void sulje3Painettu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void edellinen3Painettu()
    {
        SceneManager.LoadScene("Ohje 2");
    }
}
