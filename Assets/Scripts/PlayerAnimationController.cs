using UniRx;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public static PlayerAnimationController instance;

    [Range(0, 1f)]
    [SerializeField] private float time;
    [SerializeField] private AnimationCurve curve;

    private Animator animator;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(this);
        }
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        LifeController.instance.health.Subscribe(DamageReceived);
    }

    public void DamageReceived(int health)
    {
        if (health == 0)
        {
            //destruccion de la nave
            return;
        }
        if (health == 3) return;

        animator.SetTrigger("DamageReceived");
    }

    private void Update()
    {
        //Time.timeScale = time;
    }
}
