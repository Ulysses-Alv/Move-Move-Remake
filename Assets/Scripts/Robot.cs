using UnityEngine;
using System.Collections;

public class Robot : SpawneableObject
{
    protected override void AddForce()
    {
        float speed = GameDifficultyManager.instance.GetPowerUpSpeed();
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed), ForceMode2D.Force);
    }
    void OnEnable()
    {
        AddForce();
        StartCoroutine(StartBases());
    }
    private IEnumerator StartBases()
    {
        yield return new WaitForSeconds(Random.Range(0f,1.1f));

        Vector3 newpos = gameObject.transform.position - PlayerController.instance.gameObject.transform.position;

        GetComponent<Rigidbody2D>().AddForce(-newpos * 40, ForceMode2D.Force);

    }
}