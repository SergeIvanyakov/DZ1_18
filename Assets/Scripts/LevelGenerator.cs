using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float DistancePlatforms;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    public float Sdvig = 1f;

    private void Awake()
    {
        int PlatformCount = Random.Range(MinPlatforms, MaxPlatforms + 1);

        for (int i=0; i< PlatformCount; i++)
        {
            int prefabIndex = Random.Range(0, PlatformPrefabs.Length);
            GameObject platformPrefab = i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if (i > 0) platform.transform.localRotation = Quaternion.Euler(0, Random.Range(0, 360f), 0);
        }

        FinishPlatform.localPosition = CalculatePlatformPosition(PlatformCount);
        CylinderRoot.localScale = new Vector3(1, PlatformCount * DistancePlatforms + Sdvig, 1);
    }
    Vector3 CalculatePlatformPosition(int PlatformIndex)
    {
        return new Vector3(0, -DistancePlatforms * PlatformIndex, 0);
    }
}
