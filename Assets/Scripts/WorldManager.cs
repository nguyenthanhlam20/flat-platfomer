using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldManager : MonoBehaviour
{
    [SerializeField]
    private Button exitBtn;

    void Start()
    {
        exitBtn.onClick.AddListener(() => Home());
    }

    void Home() => SceneManager.LoadScene("Home");
}
