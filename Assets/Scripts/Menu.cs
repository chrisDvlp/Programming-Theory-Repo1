using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu : MonoBehaviour
{
    public void StartWithCube()
    {
        SceneManager.LoadScene("CubeScene");
    }

    public void StartWithSphere()
    {
        SceneManager.LoadScene("SphereScene");
    }

    public void StartWithCapsule()
    {
        SceneManager.LoadScene("CapsuleScene");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    } 
}
