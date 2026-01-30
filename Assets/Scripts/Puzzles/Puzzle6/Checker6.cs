using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker6 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(23);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(20);
    }

}
