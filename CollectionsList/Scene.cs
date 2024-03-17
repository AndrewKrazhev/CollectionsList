using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    public class Scene
    {
        List<string> _actions = new List<string>();
        List<int> _goToScene = new List<int>();
        ConsoleKeyInfo key;
        int _gotoMark;


        /// <summary>
        /// Список вариантов действия пользователя.
        /// </summary>
        public List<string> SceneActions {            
            get {return _actions; } 
            set {_actions = value; }
        }

        /// <summary>
        /// Список переходов в зависимости от выбора пользователя.
        /// </summary>
        public List<int> SceneGoTo
        {
            get { return _goToScene; }
            set { _goToScene = value; }
        }

        /// <summary>
        /// Выводит в консоль сцену.
        /// </summary>
        /// <returns>
        /// Номер следующей сцены.
        /// </returns>
        public int PrintScene() 
        {
            int i = 0;
            foreach (var action in SceneActions) 
            {
                Console.WriteLine($"{i}.{action}");
                i++;                
            }

            key = Console.ReadKey();            
                        
            while (key.KeyChar - 48 > _goToScene.Count-1)
            {
                Console.WriteLine();
                Console.WriteLine("Выбор за пределами возможного. Попробуйте снова");
                key = Console.ReadKey();
            }
                Console.WriteLine();
                return _goToScene[key.KeyChar - 48];
        }


    }
}
