using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    [SerializeField] private GameObject canvasCredit;
    public static CreditsManager instance;

    private void Awake()
    {
        instance = this;
    }
    public void TurnOnCredit()
    {
        canvasCredit.SetActive(true);
    }
    public void TurnOffCredits()
    {
        canvasCredit.SetActive(false);
    }
}