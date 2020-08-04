using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject {

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject path;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] int numberOfEnemies = 5;

    public GameObject Enemy { get => enemy; }
    public float TimeBetweenSpawns { get => timeBetweenSpawns; }
    public float SpawnRandomFactor { get => spawnRandomFactor; }
    public float MoveSpeed { get => moveSpeed; }
    public int NumberOfEnemies { get => numberOfEnemies; }

    public List<Transform> GetWaypoints() {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in path.transform) {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }
}
