using System;
using System.Reflection;

namespace RimTrans.Builder.Crawler
{
    public static class TypeLoader
    {
        private static Assembly asm;

        public static void Init(string assemblyPath)
        {
            if (asm != null)
            {
                Log.Write("TypeLoader is already initialized");
                return;
            }
            asm = Assembly.LoadFrom(assemblyPath);
        }

        public static Type Load(string name)
        {
            if (asm == null)
            {
                throw new Exception("TypeLoader is uninitialized");
            }
            return asm.GetType(name);
        }

        public static Type[] LoadAll()
        {
            if (asm == null)
            {
                throw new Exception("TypeLoader is uninitialized");
            }
            return asm.GetTypes();
        }
    }
}
