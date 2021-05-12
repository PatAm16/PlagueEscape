using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPausa : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject MenuPausaUI;

    private void Start()
    {
        MenuPausaUI.SetActive(false);
        GameIsPaused = true;
    }


    void Update()
    {if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Retomar();
            }
            else
            {
                Pausa();
            }
        }
    }

    void Retomar()
    {
        MenuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pausa()
    {
        MenuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //public void PausaJogo()
    //{
    //    SceneManager.LoadScene("Menu_Pausa");
    //}
}
