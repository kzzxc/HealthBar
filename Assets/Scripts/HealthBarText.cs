using TMPro;
using UnityEngine;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private Health _health;

    private void Start()
    {
        UpdateHealthText(_health.CurrentHealth);
    }

    private void OnEnable()
    {
        _health.HealthChanged += UpdateHealthText;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateHealthText;
    }

    private void UpdateHealthText(float currentHealth)
    {
        _healthText.text = string.Format("{0} / {1} здоровья", currentHealth, _health.MaxHealth);
    }
}
