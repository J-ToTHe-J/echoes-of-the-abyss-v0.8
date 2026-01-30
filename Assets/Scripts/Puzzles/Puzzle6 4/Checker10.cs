using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker10 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(35);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(33);
    }

}
