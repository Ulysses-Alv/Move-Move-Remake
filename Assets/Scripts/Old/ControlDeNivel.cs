using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeNivel : MonoBehaviour
{
   // public GameObject character;
   /*
    public ActivatePanel activatePanel;
    public ActivatePanel activatePanelSelectLevel;
    public ActivatePanelSettings activatePanelSettings;
    public ActivatePanelTutoria activatePanelTutoria;

    public SettingsMenuController Selectpj;
    public SettingsMenuController SelectLevel;
    public SettingsMenuController Settings;
    public SettingsMenuController Tutorial;

    bool ActivacionSettings = false;
    bool ActivacionTutorial = false;

    public bool EstaActivo;
    public bool EstaActivoDos;
    public bool EstaActivoTres;


    public void LevelSpace()
    {
        SceneManager.LoadScene("SpaceScene");

        Time.timeScale = 1f;

        PlayerPrefs.SetFloat("Roze", 0);

       // DontDestroyOnLoad(character);

        PlayerPrefs.SetFloat("Termino", 0);
        PlayerPrefs.SetFloat("PuntajeNeto", 0);


    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Destroy(GameObject.Find("GameObject"));
        Destroy(GameObject.Find("sprite"));
    }

    public void Level1()
    {
        SceneManager.LoadScene("Nivel-1");
        Time.timeScale = 1f;
        //DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Level2()
    {
        SceneManager.LoadScene("Nivel-2");
        Time.timeScale = 1f;
        //DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Level3()
    {
        SceneManager.LoadScene("Nivel-3");
        Time.timeScale = 1f;
        //DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Creditos()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Credits");
    }

    public void RestartRecord()
    {
        PlayerPrefs.SetFloat("PuntosActuales", 0);
        PlayerPrefs.SetFloat("Puntaje", 0);
    }

    public void Estela()
    {
            if (EstaActivo == true)
            {
                EstaActivo = false;
                PlayerPrefs.SetFloat("EstelaActivada", 1f);
                print(1);
            }
            else
            {
                EstaActivo = true;
                PlayerPrefs.SetFloat("EstelaActivada", 0);
                print(0);
            }
    }

    public void Propulsion()
    {
        if (EstaActivoDos == true)
        {
            EstaActivoDos = false;
            PlayerPrefs.SetFloat("PropulsionActivada", 1f);
        }
        else
        {
            EstaActivoDos = true;
            PlayerPrefs.SetFloat("PropulsionActivada", 0);
        }
    }
    public void Musica()
    {
        if (EstaActivoTres == true)
        {
            EstaActivoTres = false;
            PlayerPrefs.SetFloat("MusicaOn", 1f);
        }
        else
        {
            EstaActivoTres = true;
            PlayerPrefs.SetFloat("MusicaOn", 0);
        }
    }

    private void Update()
    {
        //print(EstaActivo + "  " + PlayerPrefs.GetFloat("EstelaActivada"));
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        

        if (activatePanelSettings.Activado == true)
        {
            //activatePanelSettings.Desactivar();
            //Settings.ReturnRight();
            ActivacionSettings = true;
        }
        
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (sceneName == "Credits")
                {
                    SceneManager.LoadScene("MainMenu");
                }
                if (sceneName == "MainMenu")
                {
                    if (ActivacionSettings == false)
                    {
                        Application.Quit();
                    }

                    if (ActivacionSettings == true)
                    {
                        activatePanelSettings.Desactivar();
                        ActivacionSettings = false;
                        Settings.ReturnRight();
                    }
                }
            }
        }
    }

    private void StartGame()
    {
        
        PlayerPrefs.SetFloat("PropulsionActivada", PlayerPrefs.GetFloat("PropulsionActivada", 0f));
        PlayerPrefs.SetFloat("EstelaActivada", PlayerPrefs.GetFloat("EstelaActivada", 0f));
        PlayerPrefs.SetFloat("MusicaOn", PlayerPrefs.GetFloat("MusicaOn", 1f));
    }*/
}
