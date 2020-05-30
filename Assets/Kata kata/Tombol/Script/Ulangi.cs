using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ulangi : MonoBehaviour
{

    public void restartGame()
    {
        SceneManager.LoadScene(2);
    }
}
