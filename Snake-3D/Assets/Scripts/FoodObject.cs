using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace SnakeGame {
    public class FoodObject : MonoBehaviour
    {

        public BoxCollider gridArea;


        void Start()
        {

        }

        private void RandomizePositiion()
        {
    
            Bounds bounds = this.gridArea.bounds;

            float x = Random.Range(bounds.min.x, bounds.max.x);

            float y = Random.Range(bounds.min.y, bounds.max.y);

            float z = Random.Range(bounds.min.z, bounds.max.z);

            this.transform.position = new Vector3(x, y, z);

        }


        public Vector3 RandomizePositionForTest()
        {
    
            

            float x = Random.Range(0, 25);

            float y = Random.Range(0, 11);

            float z = Random.Range(0, 25);

            return this.transform.position = new Vector3(x, y, z);
           
        }

            // Update is called once per frame

       public void  OnTriggerEnter(Collider other)

        {

            if (other.tag == "Player")

            {

                RandomizePositiion();

            }

        }
    }
}