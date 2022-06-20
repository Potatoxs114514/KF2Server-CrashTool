# KF2Server-CrashTool
KF2服务器崩溃重启工具

使用方法:
1.将生成的exe文件放入KFServer文件夹的根目录下(与KFServer.bat同级)
2.启动exe并根据需求添加服务器
3.将每个服务器项填上相应的启动参数(例如:KF-Rig?Mutator=DamageDisplay.DmgMut,KFMutator.KFMutator_MaxPlayersV2?MaxPlayers=10?MaxMonsters=42)
4.点击启动按钮即可

注意事项:
此程序原理为检测服务器进程的pid是否存活，在启动前请先关闭所有需要给此程序托管的服务器，点击启动按钮后会自动启动所有服务器项内的服务器。
