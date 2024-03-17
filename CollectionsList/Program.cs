using CollectionsList;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("Привет! Это пример, не проходите мимо!");
        Console.ResetColor();
        
        //Создаём список сцен. В качестве типа данных списка выступает объект - класс Scene.
        List<Scene> listScenes = new List<Scene>();
        
        listScenes.Add(new Scene());
            listScenes[0].SceneActions.AddRange(new[] { "Пойти и ничего не делать", "Пойти поесть" });
            listScenes[0].SceneGoTo.AddRange(new[] {1, 2});
        listScenes.Add(new Scene());
            listScenes[1].SceneActions.AddRange(new[] { "Купить шаурму", "Купить тетрадку" });
            listScenes[1].SceneGoTo.AddRange(new[] { 0, 2 });
        listScenes.Add(new Scene());
            listScenes[2].SceneActions.AddRange(new[] { "Обнять клоуна", "Ударить клоуна" });
            listScenes[2].SceneGoTo.AddRange(new[] { 777, 777 });
        
        //Добавление сцены к списку по одной. Громоздко, не очень понятно.
        /*Scene FirstScene = new Scene();
        FirstScene.SceneActions.Add("Упасть и не вставать");
        FirstScene.SceneActions.AddRange (new[] { "Пойти и ничего не делать", "Пойти поесть" });
        FirstScene.SceneGoTo.AddRange(new[] { 2, 3, 4 });
        FirstScene.PrintScene();
        */


        int nextScene;
        nextScene = listScenes[0].PrintScene();        

        while (nextScene != 777) {
            int tmp;
            Console.WriteLine("===============");
            tmp = listScenes[nextScene].PrintScene();
            nextScene = tmp;
        }
        Console.WriteLine("GAME OVER!!!");
    }
}