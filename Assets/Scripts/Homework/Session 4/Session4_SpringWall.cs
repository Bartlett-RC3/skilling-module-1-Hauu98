using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_SpringWall : MonoBehaviour
{
    public GameObject brickPrefab;

    int col = 6;
    int row = 3;
    int dep = 4;

    float voxelSize = 1.2f;

    GameObject[ , , ] allBricks3d;
    List<GameObject> allBricks1d;

    void Start()
    {
        allBricks3d = new GameObject[col, dep, row];
        allBricks1d = new List<GameObject>();
        CreateTower();
    }

    void CreateTower()
    {
        if (allBricks1d.Count >0)
        {
            foreach(var brick in allBricks1d)
            {
                Destroy(brick);
            }
            allBricks1d.Clear();

        }
        for(int k = 0; k < dep; k++)
        {
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    Vector3 pos = new Vector3(i*voxelSize, k*voxelSize + voxelSize/2f, j * voxelSize);
                    Quaternion rot = Quaternion.identity;
                    GameObject currentBrick = Instantiate(brickPrefab, pos, rot);

                    currentBrick.AddComponent<Rigidbody>();

                    //Brick chain connection
                    if (i > 0) //i Dimension Brick connected
                    {
                        var spring = currentBrick.AddComponent<SpringJoint>();
                        spring.connectedBody = allBricks3d[i - 1, k, j].GetComponent<Rigidbody>();
                        spring.spring = 100f;
                     }
                    if (j > 0) //j Dimension Brick connected
                    {
                        var spring = currentBrick.AddComponent<SpringJoint>();
                        spring.connectedBody = allBricks3d[i, k, j-1].GetComponent<Rigidbody>();
                        spring.spring = 100f;
                    }
                    if (k > 0) //k Dimension Brick connected
                    {
                        var spring = currentBrick.AddComponent<SpringJoint>();
                        spring.connectedBody = allBricks3d[i, k-1, j].GetComponent<Rigidbody>();
                        spring.spring = 100f;
                    }

                    currentBrick.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1-0.15f*k, 1 - 0.15f * k );

                    allBricks3d[i, k, j] = currentBrick;
                    allBricks1d.Add(currentBrick);

                }
            }
        }

    }

    // Reset button
    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 100, 40), "Create Tower"))
        {
            CreateTower();
        }
    }

}
