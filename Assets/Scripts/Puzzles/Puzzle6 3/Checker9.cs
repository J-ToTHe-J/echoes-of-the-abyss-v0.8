using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker9 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(32);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(30);
    }

}
