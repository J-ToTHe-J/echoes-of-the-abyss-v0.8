using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker11 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(38);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(36);
    }

}
