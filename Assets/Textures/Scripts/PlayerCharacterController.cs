using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    [RequireComponent(typeof(CharacterController), typeof(PlayerInputHandler), typeof(AudioSource))]
    public class PlayerCharacterController : MonoBehaviour
    {
        [Header("References")] [Tooltip("Reference to the main camera used for the player")]
        public Camera PlayerCamera;

        [Header("Rotation")] [Tooltip("Rotation speed for moving the camera")]
        public float RotationSpeed = 200f;


        float m_CameraVerticalAngle = 0f;



        PlayerInputHandler m_InputHandler;
        CharacterController m_Controller;
  

        void Awake()
        {
        }

        void Start()
        {
            // fetch components on the same gameObject
            m_Controller = GetComponent<CharacterController>();
    
            m_InputHandler = GetComponent<PlayerInputHandler>();
         
        }

            void Update()
        {
            if (Input.GetMouseButton(0))
            {
                HandleCharacterMovement();
            }

               
            }



            void HandleCharacterMovement()
        {
                // horizontal character rotation
                {
                    // rotate the transform with the input speed around its local Y axis
                    transform.Rotate(
                        new Vector3(0f, (m_InputHandler.GetLookInputsHorizontal() * RotationSpeed),
                            0f), Space.Self);
                }

                // vertical camera rotation
                {
                    // add vertical inputs to the camera's vertical angle
                    m_CameraVerticalAngle += m_InputHandler.GetLookInputsVertical() * RotationSpeed;

                    // limit the camera's vertical angle to min/max
                    //m_CameraVerticalAngle = Mathf.Clamp(m_CameraVerticalAngle, -89f, 89f);

                    // apply the vertical angle as a local rotation to the camera transform along its right axis (makes it pivot up and down)
                    PlayerCamera.transform.localEulerAngles = new Vector3(m_CameraVerticalAngle, 0, 0);
                }




            }


        }
}