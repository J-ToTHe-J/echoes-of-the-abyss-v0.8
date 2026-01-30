using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checker4 : MonoBehaviour
{
    public void CorrectOption()
    {
        SceneManager.LoadScene(17);
    }

    public void IncorrectOption1()
    {
        SceneManager.LoadScene(15);
    }

}
