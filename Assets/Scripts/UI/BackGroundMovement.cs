using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundMovement : MonoBehaviour
{
    [SerializeField] private RawImage image;
    [SerializeField] private float xVelocity, yVelocity, xDesaceleration, yDesaceleration;

    private Action backgroundAction;

    private void Start()
    {
        GameStateManager.instance.ActualState.Subscribe(SetBackgroundMovement);
        backgroundAction += BackgroundMovement;

        yVelocity *= 10;
        xVelocity *= 10;
    }

    private void SetBackgroundMovement(GameStates gameState)
    {
        if (gameState == GameStates.Lose)
        {
            backgroundAction += Desacelerate;
        }
    }

    private void Desacelerate()
    {
        if (xVelocity > 0) xVelocity -= Time.deltaTime * xDesaceleration;

        if (yVelocity > 0)  yVelocity -= Time.deltaTime * yDesaceleration;
        
        if(xVelocity <=  0 && yVelocity <= 0)
        {
            backgroundAction -= BackgroundMovement;
            backgroundAction -= Desacelerate;
        }
    }

    private void BackgroundMovement()
    {
        var newX = xVelocity / 100;
        var newY = yVelocity / 100;
        image.uvRect = new Rect(image.uvRect.position + new Vector2(newX, newY) * Time.deltaTime, image.uvRect.size);
    }
    private void Update()
    {
        backgroundAction?.Invoke();
    }
}