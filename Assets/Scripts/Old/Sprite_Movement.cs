using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sprite_Movement : MonoBehaviour
{
    public float speed = 5f;


    float numero = 0f;
    float borde = 2.2f;

    public GameObject Reset;
    public GameObject BackMenu;
    public GameObject NuevoRecord;
    public GameObject Nivel3;
    public GameObject RecordText;
    public GameObject RecordNumero;
    public GameObject MasCinco;
    public GameObject TusPuntosText;
    public GameObject TusPuntosNumero;
    public GameObject Interceptado;
    public GameObject Panel;
    public GameObject Disparo;
    public GameObject Estelas;
    public GameObject Propulsor;
    public GameObject Escudo;
    public GameObject SettingButton;

    public EscudoController EscudoController;

    public Animator animator;
    public Animator movimiento;


    //GameObject sprite;

    public bool EstaActivo;
    bool EscudoActivado;

    bool Derecha;
    bool Izquierda;
    bool PasoElTiempo;

    void OnTriggerEnter2D(Collider2D objetoQueLoToca)
    {
        if (objetoQueLoToca.gameObject.tag == "Fire" && PasoElTiempo == false)
        {
            if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales"))
            {
                NuevoRecord.gameObject.SetActive(true);
            }
            
            //Destroy(gameObject);
            //Instantiate [Explosion]

            //Time.timeScale = 0;

            Panel.gameObject.SetActive(true);

            Reset.gameObject.SetActive(true);

            BackMenu.gameObject.SetActive(true);

            RecordText.gameObject.SetActive(true);

            RecordNumero.gameObject.SetActive(true);

            TusPuntosNumero.gameObject.SetActive(true);

            TusPuntosText.gameObject.SetActive(true);

            Interceptado.gameObject.SetActive(true);    

            SettingButton.gameObject.SetActive(true);

            Destroy(this.gameObject);



        }

        if (objetoQueLoToca.gameObject.tag == "Asteroide" && PasoElTiempo == false)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            
        }

        if (objetoQueLoToca.gameObject.tag == "AsteroideGrande" && PasoElTiempo == false)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            
        }

        if (objetoQueLoToca.gameObject.tag == "Robot" && PasoElTiempo == false && Nivel3 != null)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            
        }

        if (objetoQueLoToca.gameObject.tag == "Inmunidad" && PasoElTiempo == false)
        {
            animator.SetBool("PowerUpActivado", true);

            PasoElTiempo = true;
          //  var game = GameObject.Find("Proteccion");
            //game.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("inmune");
            Invoke("Esperar", 7f);
            Destroy(objetoQueLoToca);
        }

        if(objetoQueLoToca.gameObject.tag == "Aura" && PasoElTiempo == false)
        {
            numero = numero + 1;

/*            if (MasCinco.activeInHierarchy == true)
            {
                MasCincoTexto.color();
            }*/

            if (PlayerPrefs.GetFloat("Roze") < numero)
            { 
                PlayerPrefs.SetFloat("Roze", numero);
            }

            MasCinco.gameObject.SetActive(true);
            Invoke("Texto", 0.15f);
        }

        if (objetoQueLoToca.gameObject.tag == "Disparos")
        {
            InvokeRepeating("Disparar", 0, 0.5f);
            Invoke("DetenerDisparo", 3f);
        }

        if (objetoQueLoToca.gameObject.tag == "PowerUpEscudo" && EscudoActivado == false)
        {
            Escudo.gameObject.SetActive(true);
            EscudoController.Recibidos = 0f;
        }
        if (objetoQueLoToca.gameObject.tag == "PowerUpEscudo" && EscudoActivado == true)
        {
            EscudoController.Recibidos = 0f;
        }
    }

    void Esperar()
    {
        PasoElTiempo = false;
        Debug.Log("VULNERABLE");
        animator.SetBool("PowerUpActivado", false);
    }

    void Start()
    {
        speed = PlayerPrefs.GetFloat("Velocidad");
        Reset.gameObject.SetActive(false);
        BackMenu.gameObject.SetActive(false);
        NuevoRecord.gameObject.SetActive(false);
        RecordText.gameObject.SetActive(false);
        RecordNumero.gameObject.SetActive(false);
        TusPuntosNumero.gameObject.SetActive(false);
        TusPuntosText.gameObject.SetActive(false);
        Interceptado.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        SettingButton.gameObject.SetActive(false);


        numero = 0;
        MasCinco.gameObject.SetActive(false);
        PlayerPrefs.SetFloat("Roze", 0);
    }

    void FixedUpdate()
    {
        if (Escudo.gameObject.activeSelf) PasoElTiempo = true;

        else PasoElTiempo = false;

        if (Derecha) this.transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (Izquierda) transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);


        if (PlayerPrefs.GetFloat("PuntajeNeto") == 1) NuevoRecord.gameObject.SetActive(true);

        if (PlayerPrefs.GetFloat("EstelaActivada") == 1f) Estelas.gameObject.SetActive(true);

        if (PlayerPrefs.GetFloat("EstelaActivada") == 0f) Estelas.gameObject.SetActive(false);


        if (PlayerPrefs.GetFloat("PropulsionActivada") == 1f) Propulsor.gameObject.SetActive(true);

        if (PlayerPrefs.GetFloat("PropulsionActivada") == 0f) Propulsor.gameObject.SetActive(false);

        if (Time.timeScale == 0f) MasCinco.gameObject.SetActive(false);

        float newX = Mathf.Clamp(transform.position.x, -borde, borde);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        EscudoActivado = Escudo.gameObject.activeSelf;

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        ScapeButton();
    }

    void ScapeButton() {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                if (Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    Reset.gameObject.SetActive(true);
                    BackMenu.gameObject.SetActive(true);
                }
                else
                {
                    SceneManager.LoadScene("MainMenu");
                    Time.timeScale = 1;
                }
            }
        }
    }

    public void MoverDerecha()
    {
        Derecha = true;
        movimiento.SetBool("derecha", true);
    }

    public void MoverIzquierda()
    {
        Izquierda = true;
        movimiento.SetBool("Izquierda", true);
    }

    public void Detener()
    {
        Derecha = false;
        Izquierda = false;
        movimiento.SetBool("derecha", false);
        movimiento.SetBool("Izquierda", false);
    }

    public void CambiarFloat(float NewSpeed)
    {
        PlayerPrefs.SetFloat("Velocidad", NewSpeed);
    }

    void Disparar()
    {
        Instantiate(Disparo, this.transform.position, Quaternion.identity);
    }

    void DetenerDisparo()
    {
        CancelInvoke("Disparar");
    }

    void Texto()
    {
        MasCinco.gameObject.SetActive(false);
    }


}