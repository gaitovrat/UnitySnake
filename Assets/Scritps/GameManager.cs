using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    [SerializeField]
    private GameObject _fruitPrefab;
    [SerializeField]
    private GameObject _playerPrefab;

    private void Start()
    {
        Debug.Log("Game is started.");

        Instantiate(_fruitPrefab);
        CreatePlayer();
    }

    public void GameOver()
    {
        Destroy(_playerInstance);
        _text.text = "Game over";
    }

    public void Restart()
    {
        if (_playerInstance.IsDestroyed())
        {
            CreatePlayer();
        }
        else
        {
            _playerInstance.GetComponent<Transform>().position = Vector3.zero;
        }

        _text.text = "Points: 0";
    }

    private void FixedUpdate()
    {
        var submit = Input.GetAxis("Submit");

        if (submit > 0)
        {
            Restart();
        }
    }

    private void CreatePlayer()
    {
        _playerInstance = Instantiate(_playerPrefab);
        _playerInstance.GetComponentInChildren<PlayerMovement>().Game = this;
    }

    private GameObject _playerInstance;
}
