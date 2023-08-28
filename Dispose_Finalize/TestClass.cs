namespace Dispose_Finalize
{
    internal class TestClass : IDisposable
    {
        private bool disposed = false;

        public void Hello()
        {
            Console.WriteLine("HELLO!!!");
        }

        public void Dispose()
        {
            // Free manage code resourse
            CleanUp(true);
            Console.Beep();
        }

        private void CleanUp(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Освободить управляемые ресурсы. Выполняется если вызвал пользователь объекта.
                }
                // Очистить не управляемые ресурсы. В любом случаее.
            }
            
            disposed = true;
        }
        
        ~TestClass()
        { 
            CleanUp(false);
        }
    }
}
