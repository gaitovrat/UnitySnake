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
    [SerializeField]
    private Camera _camera;

    private void Start()
    {
        Debug.Log("Game is started.");

        CreatePlayer();
        SpawnFruit();

        _isGameOver = false;
    }

    public void UpdatePoints(int points)
    {
        _text.text = $"Points: {points}";
    }

    public void GameOver()
    {
        Destroy(_playerInstance);
        Destroy(_fruitInstance);

        _isGameOver = true;
        _text.text = "Game over";
    }

    public void Restart()
    {
        CreatePlayer();
        SpawnFruit();
        UpdatePoints(0);

        _isGameOver = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && _isGameOver)
        {
            Restart();
        }
    }

    private void CreatePlayer()
    {
        _playerInstance = Instantiate(_playerPrefab);
        _playerInstance.GetComponent<Player>().Game = this;
    }

    public void SpawnFruit()
    {
        Vector3 screenPosition = _camera.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Camera.main.farClipPlane / 2));
        _fruitInstance = Instantiate(_fruitPrefab, screenPosition, Quaternion.identity);
    }

    private GameObject _playerInstance;
    private GameObject _fruitInstance;
    private bool _isGameOver;
}
