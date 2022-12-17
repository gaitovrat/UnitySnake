using Assets.Scritps;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Game.GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Game.SpawnFruit();

        _points += 15;
        Actor.Speed += 0.01f;

        Game.UpdatePoints(_points);
    }

    public void Reset()
    {
        _points = 0;
    }

    public GameManager Game { private get; set; }
    public Snake Actor { get; set; }

    private int _points;
}
