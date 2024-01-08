using UnityEngine;
using System.Collections;

public class Robot : SpawneableObject
{
    private static WaitForSeconds Wait => new(0.5f);

    private void OnEnable()
    {
        AddForce();
        StartCoroutine(StartBases());
    }
    protected override void AddForce()
    {
        float speed = GameDifficultyManager.instance.GetRobotSpeed();
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed), ForceMode2D.Force);
    }

    private IEnumerator StartBases()
    {
        yield return Wait;

        Vector3 newpos = gameObject.transform.position - PlayerController.instance.gameObject.transform.position;

        GetComponent<Rigidbody2D>().AddForce(-newpos * 35, ForceMode2D.Force);
    }
}