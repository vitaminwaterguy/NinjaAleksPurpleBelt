using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("grodon is so annoying")]
    public GameObject platform;
    float yPos = 0;

    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

  

    public static void GameOver() {
        instance.gameOverCanvas.SetActive(true);
    }
    public static void MovePlatformToTop(GameObject platform) {
        float xPosition = Random.Range(-3f, 3f);
        platform.transform.position = new Vector3(xPosition, instance.yPos, 0);
        instance.yPos += 2.5f;
    }
    public static GameController instance;
    public GameObject platform;
    public float yPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!instance) {
            instance = this;
            SpawnInitialPlatforms();
        }
    }

    // Update is called once per frame
    private void SpawnInitialPlatforms()
    {
        for (int i = 0; i < 100; i++) {
            SpawnPlatform();
        }
    }

    private void SpawnPlatform() {
        float xPosition = Random.Range(-3f, 3f);
        Instantiate(instance.platform, new Vector3(xPosition, instance.yPos, 0), Quaternion.identity);
        instance.yPos += 2.5f;
    }
}

