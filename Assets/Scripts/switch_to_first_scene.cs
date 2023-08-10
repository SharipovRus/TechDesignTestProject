using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switch_to_first_scene : MonoBehaviour
{
    public string sceneToLoad;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
