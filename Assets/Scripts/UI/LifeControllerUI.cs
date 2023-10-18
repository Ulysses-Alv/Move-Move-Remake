using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class LifeControllerUI : MonoBehaviour
{
    [SerializeField] private Image heartOne, heartTwo, heartThree;
    [SerializeField] private Sprite redHeart, blackHeart;

    private void Start()
    {
        LifeController.instance.health.Subscribe(DisplayLife);
    }

    private void DisplayLife(int health)
    {
        Image[] imageArray = new Image[] { heartThree, heartTwo, heartOne };

        for (int i = 0; i < (3 - health); i++)
        {
            imageArray[i].sprite = blackHeart;
        }
    }
}
