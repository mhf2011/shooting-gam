using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    // [SerializeField] ParticleSystem DeathExplosion;

    [SerializeField] Image healthBar;
    [SerializeField] float maxHealth = 100;
    [SerializeField] float HP = 100;

    robot robot;
    void Start()
    {
        robot = GetComponent<robot>();
        UpdateHealthUI();
    }
    void Update()
    {
        healthBar.fillAmount = HP / maxHealth;
    }
    private float applyDamage(float damage)
    {
        HP -= damage;
        HP = Mathf.Clamp(HP, 0, maxHealth);
        UpdateHealthUI();
        return HP;
    }
    public void Damage(float damage)
    {
        float newHP = applyDamage(damage);
        if (newHP <= 0)
        {
            robot.enabled = false;
        }
    }
    private void UpdateHealthUI()
    {
        healthText.text = Mathf.CeilToInt(HP).ToString();
    }
}