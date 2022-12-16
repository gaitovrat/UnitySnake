using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    private void Start()
    {
        Debug.Log("Game is started.");
        Debug.Log($"Text is {_text.text}");
    }
}
