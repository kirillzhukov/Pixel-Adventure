using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string sceneName; // Имя сцены для переключения

    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName); // Загружаем заданную сцену
    }
}
