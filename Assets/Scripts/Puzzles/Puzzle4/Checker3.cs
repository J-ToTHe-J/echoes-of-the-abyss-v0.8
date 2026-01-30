using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker3 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(14);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(12);
    }

}
