using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ApplicationQuit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
