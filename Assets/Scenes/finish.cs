using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(8);
    }
}
