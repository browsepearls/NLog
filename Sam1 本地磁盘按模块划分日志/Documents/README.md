# 使用方法

添加引用 --> Logger.dll

添加命名空间 --> BrowsePearls.Log



日志等级共有以下5种。

Logger.Debug("I am a log.",module);

Logger.Info("I am a log.",module);

Logger.Warn("I am a log.",module);

Logger.Error("I am a log.",module);

Logger.Fatal("I am a log.",module);



另外，Logger提供写文件的API，使开发人员无需亲自使用File等类打开写入，关闭文件。

Logger.Report("I am a piece of data.", fileName);



# 其他

[Logger]

依赖的dll：NLog.dll 4.0.0.0

.NET Framework版本：4.5

使用的配置文件：NLog.config

所以，我们需要把，NLog.dll V4.0.0.0和NLog.config一起拷贝到应用程序的根目录下。

