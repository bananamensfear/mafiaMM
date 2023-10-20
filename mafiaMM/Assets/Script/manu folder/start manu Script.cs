using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmanuScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("gameScene");
    }    
    public void Quit()
    {
        Application.Quit();
    }
}
