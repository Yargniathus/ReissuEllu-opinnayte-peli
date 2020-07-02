using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHallintaKoodi : MonoBehaviour
{
    public GameObject Menu = null;
    
    
    public void JatkaPainettu()
    {
        GameObject.Destroy(Menu);        
    }

    public void AlustaPainettu ()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Pisteet.pisteet = 100;
        instantiatepalikka.existingPositions.Clear();
    }

    public void LopetaPainettu()
    {
        Pisteet.pisteet = 100;
        instantiatepalikka.existingPositions.Clear();
        SceneManager.LoadScene("StartScene");
    }
}
