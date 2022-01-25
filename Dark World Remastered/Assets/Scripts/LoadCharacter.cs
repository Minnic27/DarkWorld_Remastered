using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform[] spawnPoints;
    public GameObject clone;
    
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        GameObject prefab = characterPrefabs[selectedCharacter];
        clone = Instantiate(prefab, spawnPoints[spawnIndex].position, Quaternion.identity);
    }
}
