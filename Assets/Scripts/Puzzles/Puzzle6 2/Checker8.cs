using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker8 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(29);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(27);
    }

}
