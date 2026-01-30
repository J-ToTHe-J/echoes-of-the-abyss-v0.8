using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker14 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(47);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(45);
    }

}
