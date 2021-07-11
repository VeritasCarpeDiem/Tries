using System;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }
        public static Singleton Instance { get; } = new Singleton();


    }
}
