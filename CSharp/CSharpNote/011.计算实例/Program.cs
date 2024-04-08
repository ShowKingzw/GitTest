//计算100天是多少周零几天

//int days = 100;
//int weeks = days / 7;//计算有完整的周数
//int day = days % 7;//多余的几天 
//Console.WriteLine("{0}天是{1}周零{2}天。", days, weeks, day);
//Console.ReadKey();


//计算107653秒是几天几小时几分钟几秒

int seconds = 107653;
int days = seconds / 86400;//一天是60*60*24=86400s
int secs = seconds % 86400;//不足一天的秒数
int hours = secs / 3600;//多少小时
secs = secs % 3600;//不足一小时的秒数
int minutes = secs / 60;//多少分钟
secs = secs % 60;//剩余多少秒
Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒。", seconds, days, hours, minutes, secs);
Console.ReadKey();
