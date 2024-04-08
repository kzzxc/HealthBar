using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Health _health;

    private void Start()
    {
        _slider.value = _health.CurrentHealth;
    }

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float currentHealth)
    {
        float normalizedHealth = currentHealth / _health.MaxHealth;
        _slider.value = normalizedHealth;
    }
}
