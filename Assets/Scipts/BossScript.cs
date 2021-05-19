using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{
    public static int vidaBoss=100;

    private void Update()
    {
        if (vidaBoss == 0)
        {
            SceneManager.LoadScene("WinEscene");
        }
    }

}

