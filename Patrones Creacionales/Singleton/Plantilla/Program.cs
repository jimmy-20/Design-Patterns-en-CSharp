using Singleton;


SingletonTemplate singleton = SingletonTemplate.GetInstance();
SingletonTemplate singleton2 = SingletonTemplate.GetInstance();
SingletonTemplate singleton3 = SingletonTemplate.GetInstance();

for (int i = 0; i < 100000; i++)
{
    SingletonTemplate singleton4 = SingletonTemplate.GetInstance();
    Console.WriteLine(i);
}
