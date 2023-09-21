namespace Tools
{
    public class Log
    {
        private static Log _instance = null;
        private string _path;
        //proteger contra hilos al mismpo tiempo
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            //lockear contra hilos
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }


        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);

        }

    }
}