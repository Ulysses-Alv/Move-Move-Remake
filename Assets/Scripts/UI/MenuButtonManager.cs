using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField] private Button Play;
    [SerializeField] private Button Credits;
    [SerializeField] private Button Exit;

    private void Start()
    {
        Play.onClick.AddListener(() => SceneManager.LoadScene("Game"));
        Credits.onClick.AddListener(() => CreditsManager.instance.TurnOnCredit());
        Exit.onClick.AddListener(() => CreditsManager.instance.TurnOffCredits());
    }
}
