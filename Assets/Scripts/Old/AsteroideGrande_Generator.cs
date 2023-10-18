using System.Collections;
using Unity.Android.Gradle;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroideGrande_Generator : MonoBehaviour
{
    public GameObject objeto;
    /*public float TiempoDeEspera = 0f;
float TiempoDeRepeticion = 2f;

 public float EscalaDelTiempo = 1f;
  private float tiempoDelFrameConTimeScale = 0f;
  private float tiempoAMostrarEnSegundos = 0f;

  void Update()
  {
     tiempoDelFrameConTimeScale = Time.deltaTime * EscalaDelTiempo;
     tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;

     if(tiempoAMostrarEnSegundos > 10f && TiempoDeRepeticion != 0f)
     {
          tiempoAMostrarEnSegundos = tiempoAMostrarEnSegundos - 10f;
          TiempoDeRepeticion = TiempoDeRepeticion - 3f;
          Debug.Log(TiempoDeRepeticion);
     }
  }*/
    void Start()
    {
        InvokeRepeating("GeneradorDeFire", 5f, 1.7f);
        gameObject.transform.localScale= new Vector3(0.6f,0.6f,.6f);
    }

    void GeneradorDeFire()
    {
        //Busca el GameObject Fire que esta fuera de camara pero se mueve hasta desaparecer 
        //Para dar un pequeño tiempo de espera entre que entras y empezas a jugar
        var selectedFire = GameObject.Find("AsteroideGrande");
        //El empty GameObj que a partir de ahi se genera el Fire
        var FireGenerator = GameObject.Find("Fire_Generator");
        //Al no haber un fire porque selectedFire dio null genera el Fire
        if (selectedFire == null)
        {
            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.right * 1f;
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.left * 2f;
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.right * 2f;

            Instantiate(objeto, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(objeto, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
            Instantiate(objeto, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(objeto, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(objeto, FireGenerator.transform.position, Quaternion.identity); //este es el Central
        }
    }
}

/*
public class ObjectFactory
{
    public readonly FactoryConfiguration factoryConfiguration;

    public ObjectFactory(FactoryConfiguration powerUpsConfiguration)
    {
        this.factoryConfiguration = powerUpsConfiguration;
    }

    public ObjectExample CreatePrefab(string id)
    {
        ObjectExample prefab = factoryConfiguration.GetObjectPrefabById(id);

        return Object.Instantiate(prefab);
    }
    public ObjectExample GetObjectExample(string id)
    {
        return factoryConfiguration.GetObjectPrefabById(id);
    }
}
public class HeroCreator : MonoBehaviour
{
    [SerializeField] private Weapon[] _possibleWeapon;
    [SerializeField] private Skin[] _possibleSkin;
    [SerializeField] private Helmet[] _possibleHelmet;
    [SerializeField] private ChessPlate[] _possibleChess;
    [SerializeField] private Boots[] _possibleBoots;
    [SerializeField] private Leggins[] _possibleLeggs;

    private readonly HeroBuilder _heroBuilder = new HeroBuilder();

    public void SelectWeapon(int weaponIndex)
    {
        _heroBuilder.WithWeapon(_possibleWeapon[weaponIndex]);
    }
    public void SelectSkin(int skinIndex)
    {
        _heroBuilder.WithSkin(_possibleSkin[skinIndex]);
    }
    public void SelectH(int HIndex)
    {
        _heroBuilder.WithHelmet(_possibleHelmet[HIndex]);
    }
    public void SelectChess(int chessIndex)
    {
        _heroBuilder.WithChessPlate(_possibleChess[chessIndex]);
    }
    public void SelectLeggs(int leggsIndex)
    {
        _heroBuilder.WithLeggins(_possibleLeggs[leggsIndex]);
    }
    public void SelectBoots(int bootsIndex)
    {
        _heroBuilder.WithBoots(_possibleBoots[bootsIndex]);
    }

    public void CreateHero()
    {
        _heroBuilder.Build();
    }
}

public class Builder
{
    public Hero Build()
    {
        var hero = Object.Instantiate(this.hero, _position, _rotation);

        hero.SetComponents(skin, helmet, weapon, chess, leggins, boots);

        return hero;
    }
}
*/