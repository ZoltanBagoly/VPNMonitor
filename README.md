# VPNMonitor
VPN Monitor is a little system tray application showing a message, when one of the monitored connections state has changed.

## Configuration

Right click the system tray icon to open application's menu, and select Settings, or manually edit the 'VPNMonitor.cfg' file:

```
<?xml version="1.0" encoding="utf-8"?>
<MonitorSettings>
  <BalloonTipTimeout>5</BalloonTipTimeout>
  <Items>
    <Item Id="{E7A3092A-A86E-4120-91FB-568B828264B6}" Name="Company VPN - SSTP" />
  </Items>
</MonitorSettings>
```
