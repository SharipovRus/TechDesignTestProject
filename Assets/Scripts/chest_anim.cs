using UnityEngine;

public class chest_anim : MonoBehaviour
{
    public GameObject coinPrefab; // Префаб монеты
    public float spawnDelay = 1.0f; // Задержка перед созданием монеты (в секундах)

    Animator animator;
    const string PRESS_ANIM = "press";

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetTrigger(PRESS_ANIM);
        // Вызываем метод SpawnCoin с задержкой
        Invoke("SpawnCoin", spawnDelay);
    }

    private void SpawnCoin()
    {
        if (coinPrefab != null)
        {
            // Создаем монету перед сундуком
            Vector3 spawnPosition = transform.position - new Vector3(0, 0, 1); // Примерно перед сундуком
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
