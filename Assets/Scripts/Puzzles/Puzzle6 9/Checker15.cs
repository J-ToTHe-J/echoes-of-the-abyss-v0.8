using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker15 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(50);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(48);
    }

}
