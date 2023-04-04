//Code followed and obtained from youtube tutorial series https://www.youtube.com/watch?v=aHGlLxh6a88&list=RDCMUCG8bDPqp3jykCGbx-CiL7VQ&index=9
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class GameReseter : MonoBehaviour  
    {
        public void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("Ball")) return;
            SceneManager.LoadScene("CharacterSelection");
        }
    }
}