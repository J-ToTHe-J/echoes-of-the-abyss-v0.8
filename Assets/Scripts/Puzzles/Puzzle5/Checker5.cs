using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker5 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(19);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(17);
    }

}
