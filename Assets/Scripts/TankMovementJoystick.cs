using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class TankMovementJoystick : MonoBehaviour
    {

        public Animator animator;                                                   //for animation
        public float speed;
        public Joystick joystick;

        // Use this for initialization
        void Start()
        {

        }

        private void Update()
        {
            //float horizontal = Input.GetAxisRaw("Horizontal");
            float horizontal = joystick.Horizontal;
            float Vertical = joystick.Vertical;
            RunAnim(horizontal);
            playhorizontal(horizontal, Vertical);
           

        }
       
        private void RunAnim(float horizontal)
        {
            //move charector horizontally
            Vector3 position = transform.position;
            position.x += horizontal * speed * Time.deltaTime;
            transform.position = position;

        }

        private void playhorizontal(float horizontal, float Vertical)
        {
            animator.SetFloat("Speed", Mathf.Abs(horizontal)); //changing speed to abs

            Vector3 scale = transform.localScale;
            if (horizontal < 0)
            {
                scale.x = -1f * Mathf.Abs(scale.x); // changig speed to abs
            }
            else if (horizontal > 0)
            {
                scale.x = Mathf.Abs(horizontal);
            }
            transform.localScale = scale;

        }
    }
}