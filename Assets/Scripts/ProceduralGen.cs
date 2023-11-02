using UnityEngine;

public class ProceduralGen : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public GameObject tilePrefab;

    private void Start()
    {
        GenerateLevel();
    }

    private void GenerateLevel()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 tilePosition = new Vector3(x, 0, y);
                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);
                // Customize the tile based on procedural generation rules or algorithms
                // For simplicity, we'll just randomly set the tile color
                tile.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }
}