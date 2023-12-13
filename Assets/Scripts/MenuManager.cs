using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
     public void Oyna()
     {
        SceneManager.LoadScene(1);
     }
     public void Kapat()
     {
        Application.Quit();
     }
}
