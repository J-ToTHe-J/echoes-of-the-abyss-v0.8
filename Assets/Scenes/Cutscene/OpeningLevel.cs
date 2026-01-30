using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningLevel : MonoBehaviour
{
    public float changeTime;
    void Update()
    {
        changeTime -= Time.deltaTime;
        if(changeTime<= 0)
        {
        SceneManager.LoadScene("level_0", LoadSceneMode.Single);
        }
    }
}
