using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode.World_Handling
{
    class IOHandler
    {
        public static int[,] loadLevelFromFile(String file)
        {
            using (var sr = new StreamReader(file))
            {
                var serializer = new JsonSerializer();
                return (int[,])serializer.Deserialize(sr, typeof(int[,]));
            }
        }

        public void loadLevelFromFileDebug(String file)
        {
            using (var sr = new StreamReader(file))
            {
                var serializer = new JsonSerializer();
                Console.WriteLine((int[,])serializer.Deserialize(sr, typeof(int[,])));
            }
        }
    }
}
