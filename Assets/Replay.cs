using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Macara asta sa mearga");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
