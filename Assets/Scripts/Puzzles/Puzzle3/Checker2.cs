using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker2 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(11);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(9);
    }

}
