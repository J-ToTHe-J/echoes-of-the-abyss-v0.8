using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(4);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(1);
    }

}
