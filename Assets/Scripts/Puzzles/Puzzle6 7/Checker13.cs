using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker13 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(44);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(42);
    }

}
