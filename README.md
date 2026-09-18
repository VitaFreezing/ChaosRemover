# ChaosRemover

**ChaosRemover** is an [EXILED](https://github.com/ExMod-Team/EXILED) plugin for **SCP: Secret Laboratory** that silences and removes the C.A.S.S.I.E. announcement when a Chaos Insurgency wave spawns.

---

## 🎯 Features

- **Silences Standard Chaos Waves**: Suppresses CASSIE's announcement (`"Attention all personnel. Detected X Chaos Insurgency forces at Gate A..."`) when standard Chaos Insurgency waves spawn.
- **Silences Mini Chaos Waves**: Suppresses CASSIE's announcement (`"Acquired X additional hostile forces at Gate A..."`) when Chaos mini waves spawn.
- **Configurable**: Both standard and mini waves can be individually toggled in the config.

---

## 📦 Installation

1. Download the latest **`ChaosRemover.dll`** from the [**Releases**](https://github.com/VitaFreezing/ChaosRemover/releases/latest) page.
2. Place `ChaosRemover.dll` into your server's EXILED plugins directory:
   - **Windows**: `%appdata%\EXILED\Plugins\`
   - **Linux**: `~/.config/EXILED/Plugins/`
3. Restart your server.

---

## ⚙️ Configuration

A configuration block is automatically generated in your server's plugins `conig` under `ChaosRemover`:

```yaml
ChaosRemover:
  # Whether or not the plugin is enabled.
  is_enabled: true
  # Whether or not debug messages should be displayed in the server console.
  debug: false
  # Silence the CASSIE announcement for standard Chaos Insurgency spawn waves.
  silence_standard_wave: true
  # Silence the CASSIE announcement for Chaos Insurgency mini waves.
  silence_mini_wave: true
```

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).