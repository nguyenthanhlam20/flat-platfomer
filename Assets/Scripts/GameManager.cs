using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField]
    private TextMeshProUGUI txt;

    private int coin = 0;

    public void GainCoin()
    {
        coin += 1;
        txt.text = "Coin: " + coin;

        if(coin == 10)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
