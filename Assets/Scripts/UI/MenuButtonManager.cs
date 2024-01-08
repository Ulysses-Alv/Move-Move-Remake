using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField] private Button Play;

    private void Start()
    {
        Play.onClick.AddListener(() => SceneManager.LoadScene("Game"));
    }
}