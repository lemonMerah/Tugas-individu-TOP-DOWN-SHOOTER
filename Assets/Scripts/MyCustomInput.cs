// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/MyCustomInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyCustomInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyCustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyCustomInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""e9a672a9-13c8-48f4-ade1-a3380915f4e2"",
            ""actions"": [
                {
                    ""name"": ""SetDirection"",
                    ""type"": ""Value"",
                    ""id"": ""6a661d11-0523-43ac-bf72-151db343b81d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""79d7f81c-04ed-40ed-a1d0-a31f063db36d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""414d07e4-8b7d-4498-bf4c-e40dffdfac3b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""11fa1174-416d-4420-8b7f-12c2d835c19c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d05bd363-8909-4a5b-bc6b-438826021755"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""32d70193-d054-407e-a943-979584f7788a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_SetDirection = m_Gameplay.FindAction("SetDirection", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_SetDirection;
    public struct GameplayActions
    {
        private @MyCustomInput m_Wrapper;
        public GameplayActions(@MyCustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetDirection => m_Wrapper.m_Gameplay_SetDirection;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @SetDirection.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSetDirection;
                @SetDirection.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSetDirection;
                @SetDirection.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSetDirection;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SetDirection.started += instance.OnSetDirection;
                @SetDirection.performed += instance.OnSetDirection;
                @SetDirection.canceled += instance.OnSetDirection;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnSetDirection(InputAction.CallbackContext context);
    }
}
