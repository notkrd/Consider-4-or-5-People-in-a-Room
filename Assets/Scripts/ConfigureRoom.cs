using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigureRoom : MonoBehaviour
{
    public GameObject a_wall;
    public GameObject a_floor;

    // Use this for initialization
    void Start ()
    {
        MakeRoom(5, 3, -1, -1);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void MakeRoom (int room_width, int room_height, int left_bound, int lower_bound)
    {
        MakeFloor(room_width, room_height, left_bound, lower_bound);
        MakeHorizontalWall(room_width + 2, left_bound - 1, lower_bound - 1);
        MakeHorizontalWall(room_width + 2, left_bound - 1, lower_bound + room_height);
        MakeVerticalWall(room_height, left_bound - 1, lower_bound);
        MakeVerticalWall(room_height, left_bound + room_width, lower_bound);
    }

    void MakeHorizontalWall(int wall_length, int left_bound, int lower_bound)
    {
        for (int wall_h = 0; wall_h < wall_length; wall_h++)
        {
            var new_wall = Instantiate(a_wall, new Vector3(left_bound + wall_h, lower_bound, 0), Quaternion.identity);
            new_wall.transform.parent = gameObject.transform;
        }
    }
    void MakeVerticalWall(int wall_height, int left_bound, int lower_bound)
    {
        for (int wall_k = 0; wall_k < wall_height; wall_k++)
        {
            var new_wall = Instantiate(a_wall, new Vector3(left_bound, lower_bound + wall_k, 0), Quaternion.identity);
            new_wall.transform.parent = gameObject.transform;
        }
    }
    void MakeFloor(int room_width, int room_height, int left_bound, int lower_bound)
    {
        for (int floor_h = 0; floor_h < room_width; floor_h++)
        {
            for (int floor_k = 0; floor_k < room_height; floor_k++)
            {
                var new_floor = Instantiate(a_floor, new Vector3(left_bound + floor_h, lower_bound + floor_k, 0), Quaternion.identity);
                new_floor.transform.parent = gameObject.transform;
            }
        }
    }
}
