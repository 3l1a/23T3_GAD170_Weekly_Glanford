using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoder : MonoBehaviour
{
    // method to open scene


    public void LodeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
