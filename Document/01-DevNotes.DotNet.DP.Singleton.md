# 单体模式 Singleton
## 一、定义
保证类仅有一个实例，并提供一个访问它的全局访问点。
## 二、结构图

![image](http://oexa57lqy.bkt.clouddn.com/20160619110657690.jpg)


## 三、适用场景

1、当类只能有一个实例而且客户可以从一个众所周知的访问点访问它时。 

2、当这个唯一实例应该是通过子类化可扩展的，并切客户应该无需更改代码就能使用一个扩展的实例时。

## 四、模式实现

### 1、基本的单体模式

Singleton类定义一个GetInstance操作，允许客户访问它的唯一实例。GetInstance是一个静态方法，主要负责创建自己的唯一实例。

```
/// <summary>
    /// 单体模式一
    /// </summary>
    public class Singleton
    {
        //私有，静态实例
        private static Singleton _instance = null;

        //私有构造函数
        private Singleton()
        {

        }

        //静态工厂方法
        public static Singleton CreateInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
```
### 2、懒加载的单体模式

```
   /// <summary>
    /// 延迟实例化的单体模式
    /// </summary>
    public class SingletonForLazy
    {
        //初始暂不实例化
        private static SingletonForLazy _instance = null;

        //私有的构造子(构造器,构造函数,构造方法)
        private SingletonForLazy() { }

        //静态的工厂方法，需要使用时才去创建该单体
        public static SingletonForLazy GetInstance()
        {
            return _instance ?? (_instance = new SingletonForLazy());
        }
    }
```
### 3、线程安全的单体模式

```
 /// <summary>
    /// 线程安全的单体模式
    /// </summary>
    public class SingletonForThread
    {
        /// <summary>
        /// 单体实例
        /// </summary>
        private static SingletonForThread _instance;
        /// <summary>
        /// 线程安全锁
        /// </summary>
        private static object _lock = new object();

        /// <summary>
        /// 构造函数
        /// </summary>
        private SingletonForThread()
        {
        }

        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <returns></returns>
        public static SingletonForThread GetInstance()
        {
            //双重锁方式较好地解决了多线程下的单例模式实现
            if (null == _instance)
            {
                lock (_lock)
                {
                    if (null == _instance)
                    {
                        _instance = new SingletonForThread();
                    }
                }
            }
            return _instance;
        }
    }
```
