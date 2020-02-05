using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AloitusruutuKoodi : MonoBehaviour
{    

    public void Aloita_Painettu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Lopeta_Painettu()
    {
        Application.Quit();
    }
}
