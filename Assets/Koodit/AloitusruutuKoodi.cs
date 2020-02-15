using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AloitusruutuKoodi : MonoBehaviour
{
    public GameObject OhjeTaulu = null;

    public void Aloita_Painettu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Lopeta_Painettu()
    {
        Application.Quit();
    }

    public void Ohjeet_Painettu()
    {
        GameObject apumenu = Instantiate(this.OhjeTaulu, new Vector3(0,0,0), Quaternion.identity);
        apumenu.name = "ohjeet";
    }
}
