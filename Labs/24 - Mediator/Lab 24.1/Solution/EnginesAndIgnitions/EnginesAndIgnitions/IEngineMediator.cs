namespace Wincubate.MediatorLabs
{
    interface IEngineMediator
    {
        void Register( Accelerator accelerator );
        void Register( Brake brake );
        void Register( GearBox gearBox );
        void Register( Ignition ignition );

        void OnAcceleratorEnabledChanged( bool isEnabled );
        void OnAcceleratorPressed();
        void OnBreakEnabledChanged( bool isEnabled );
        void OnBrakePressedChanged( bool isPressed );

        void OnGearBoxEnabledChanged( bool isEnabled );
        void OnGearChanged( Gear newGear );

        void OnIgnitionEnabledChanged( bool on );
    }
}
