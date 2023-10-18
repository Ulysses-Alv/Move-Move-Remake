using UniRx;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public static ShieldController instance;

    public bool isShieldActive;

    private ReactiveProperty<int> life = new ReactiveProperty<int>(initialValue: 0);

    public int currentLife { get { return life.Value; } }

    [SerializeField] private int lifeValue = 2;
    [SerializeField] private Sprite crackedShieldSprite;
    [SerializeField] private Sprite fullShieldSprite;

    Animator animator;
    SpriteRenderer spriteRenderer;


    private void Awake()
    {
        instance = this;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        life.Subscribe(SetAnimations);
    }

    public void TurnOnShield()
    {
        life.Value = lifeValue;
        isShieldActive = true;
    }
    public void DamageShield()
    {
        if (life.Value <= 0) return;
        life.Value--;
    }
    private void SetAnimations(int life)
    {
        switch (life)
        {
            case 0:
                isShieldActive = false;
                spriteRenderer.enabled = false;
                break;
            case 1:
                spriteRenderer.sprite = crackedShieldSprite;
                animator.SetTrigger("cracked");
                break;
            case 2:
                spriteRenderer.sprite = fullShieldSprite;
                break;
        }
    }

}
