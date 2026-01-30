using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker1 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(8);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(6);
    }

}
