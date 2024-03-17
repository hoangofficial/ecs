#SingleInstance force
#MaxHotkeysPerInterval 1000
#UseHook

SetTitleMatchMode, 2

vUsername := "Administrator"
vPassword := "ecs123!"

Sleep 1000
ControlSetText, Edit1, %vUsername%, Windows Security
Sleep, 50
ControlSetText, Edit2, %vPassword%, Windows Security
Sleep, 50
ControlSend, , {Enter}, Windows Security
Sleep, 5000
If WinActive("Remote Desktop Connection")
{
	ControlClick, Yes, Remote Desktop Connection
}
