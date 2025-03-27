using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverScreen;
    public float Distance;
    public float Speed = 1f;
    public ObstacleSpawner Spawner;
    public OverlayUI Overlay;
    public float SpawnDistance = 10f;

    private bool _running;
    private float _nextSpawn;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _running = false;
    }

    private void Update()
    {
        if (_running)
        {
            Distance += Time.deltaTime * Speed;
            if (Distance > _nextSpawn)
            {
                SpawnObstacle();
            }
        }
    }

    public void SpawnObstacle()
    {
        _nextSpawn = Distance + SpawnDistance;
        Spawner.Spawn();
    }

    public void StartGame()
    {
        Distance = 0f;
        _nextSpawn = SpawnDistance;
        _running = true;
    }

    public void GameOver()
    {
        if ((int)Distance > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", (int)Distance);
            Overlay.UpdateHighScore();
        }
        GameOverScreen.SetActive(true);
        _running = false;
    }

    public bool IsRunning()
    {
        return _running;
    }
}
