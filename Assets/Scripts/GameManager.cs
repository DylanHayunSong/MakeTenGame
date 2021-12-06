using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBehaviour<GameManager>
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private void Initialize()
    {
        GameObject gameManager = new GameObject("GameManager");
        gameManager.AddComponent<GameManager>();

        GameObject sceneChangeManager = new GameObject("SceneChangeManager");
        sceneChangeManager.AddComponent<SceneChangeManager>();
        sceneChangeManager.transform.parent = gameManager.transform;
    }
}
