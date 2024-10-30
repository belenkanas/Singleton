using Library;

public class Singleton<T> where T: new()
{
    
    private static T instance;

    public static T Instance //propiedad de clase
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
   
}