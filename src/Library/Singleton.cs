using Library;

public class Singleton<T> where T: new()
{
    
    private static T instance;

    public static T Instance //propiedad de clase Va a devolver el tipo de clase que yo ingresé.
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