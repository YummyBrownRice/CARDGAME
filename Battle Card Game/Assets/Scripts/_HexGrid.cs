using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _HexGrid : MonoBehaviour
{
    public int width = 6;
    public int height = 6;
    public _HexCell _cellPrefab;

    _HexCell[] cells;

    void Start()
    {
        Debug.Log("???");
        cells = new _HexCell[height * width];
        for (int z = 0, i = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                Debug.Log("Hi");
                CreateCell(x, z, i++);
            }
        }
    }

    void CreateCell(int x, int z, int i)
    {
        Vector3 position;
        position.x = x * 10f;
        position.y = 0f;
        position.z = z * 10f;

        _HexCell cell = cells[i] = Instantiate<_HexCell>(_cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
        Debug.Log("Hello");
    }
}
