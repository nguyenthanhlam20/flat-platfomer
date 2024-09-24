using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    private Button playBtn;

    void Start()
    {
        playBtn.onClick.AddListener(() => Play());
    }

    void Play() => SceneManager.LoadScene("World");
}
