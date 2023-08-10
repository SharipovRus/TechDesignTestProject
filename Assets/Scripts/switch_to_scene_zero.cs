using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switch_to_scene_zero : MonoBehaviour
{
    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ReturnToFirst);
    }

    private void ReturnToFirst()
    {
        SceneManager.LoadScene(0); // Замените "NameOfFirstScene" на имя вашей первой сцены
    }
}
