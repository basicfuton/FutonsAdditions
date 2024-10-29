using System;

namespace Celeste.Mod.FutonsAdditions;

public class FutonsAdditionsModule : EverestModule {
    public static FutonsAdditionsModule Instance { get; private set; }

    public override Type SettingsType => typeof(FutonsAdditionsModuleSettings);
    public static FutonsAdditionsModuleSettings Settings => (FutonsAdditionsModuleSettings) Instance._Settings;

    public override Type SessionType => typeof(FutonsAdditionsModuleSession);
    public static FutonsAdditionsModuleSession Session => (FutonsAdditionsModuleSession) Instance._Session;

    public override Type SaveDataType => typeof(FutonsAdditionsModuleSaveData);
    public static FutonsAdditionsModuleSaveData SaveData => (FutonsAdditionsModuleSaveData) Instance._SaveData;

    public FutonsAdditionsModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(FutonsAdditionsModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(FutonsAdditionsModule), LogLevel.Info);
#endif
    }

    public override void Load() {
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}