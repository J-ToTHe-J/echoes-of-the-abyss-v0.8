using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker12 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(41);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(39);
    }

}
