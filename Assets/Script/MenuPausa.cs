using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    public void Pausa()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Riprendi()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ReturnHome() {
        SceneManager.LoadScene("MainStart");
    }
}
