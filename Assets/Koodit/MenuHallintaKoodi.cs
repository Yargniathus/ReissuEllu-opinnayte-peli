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
    }

    public void LopetaPainettu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
