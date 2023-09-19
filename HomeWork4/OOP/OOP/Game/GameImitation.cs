using OOP.Game.AbstractClasses;
using OOP.Game.GameElements;

namespace OOP.Game
{
    /// <summary>
    /// Класс, представляющий игровой процесс.
    /// </summary>
    public class GameImitation
    {
        /// <summary>
        /// Метод для запуска игры.
        /// </summary>
        public void PlayGame()
        {
            var human = new Human(10, 5, 1);

            var elph = new Elph(10, 3, 2);

            var trees = new Tree[3];

            var stones = new Stone[4];

            var wolves = new Wolf[2];

            var bears = new Bear[3];

            var bananas = new Banana[5];

            var cherries = new Cherry[4];

            var apples = new Apple[6];

            var random = new Random();

            for (var i = 0; i < trees.Length; i++)
            {
                trees[i] = new Tree(random.Next(0, 10));
            }

            for (var i = 0; i < stones.Length; i++)
            {
                stones[i] = new Stone(random.Next(1, 10));
            }

            for (var i = 0; i < wolves.Length; i++)
            {
                wolves[i] = new Wolf(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
            }

            for (var i = 0; i < bears.Length; i++)
            {
                bears[i] = new Bear(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
            }

            for (var i = 0; i < bananas.Length; i++)
            {
                bananas[i] = new Banana(random.Next(1, 10));
            }

            for (var i = 0; i < cherries.Length; i++)
            {
                cherries[i] = new Cherry(random.Next(1, 10));
            }

            for (var i = 0; i < apples.Length; i++)
            {
                apples[i] = new Apple(random.Next(1, 10));
            }

            human.Move(0, 0, 5, 5);

            Console.WriteLine($"Начальные харакетристики человека:  HP = {human.HP}, Speed = {human.Speed}, Attack = {human.Attack}");

            Console.WriteLine($"Человек пришел в точку {human.X} {human.Y}");

            bananas[0].SetBonus(human);

            Console.WriteLine($"Человек нашел {nameof(Banana)}. Бонус к скорсти: +{bananas[0].BonusValue}");

            Console.WriteLine($"Человек полчуил бонус {nameof(Banana)}: Скорость человека: {human.Speed}");

            Console.WriteLine($"Человек встретил волка. Здоровье волка: {wolves[0].HP}");

            human.MakeAttack(wolves[0]);

            Console.WriteLine($"Здоровье волка после атаки: {wolves[0].HP}");

            Console.WriteLine($"Человек встретил медведя. Здоровье медведя: {bears[0].HP}");

            bears[0].MakeAttack(human);

            Console.WriteLine($"Здоровье медведя после атаки: {bears[0].HP}");

            Console.WriteLine($"Здоровье человека после атаки медведя: {human.HP}");

            Console.WriteLine($"Человек столкнулся с деревом. Здоровье человека до столкновения: {human.HP}");

            trees[1].DamagePerson(human);

            Console.WriteLine($"Здоровье человека после столкновения с деревом: {human.HP}");

            Console.WriteLine($"Начальные харакетристики эльфа:  HP = {elph.HP}, Speed = {elph.Speed}, Attack = {elph.Attack}");

            Console.WriteLine($"Эльф пришел в точку {elph.X} {elph.Y}");

            cherries[0].SetBonus(elph);

            Console.WriteLine($"Эльф нашел {nameof(Cherry)}. Бонус к здоровью: +{cherries[0].BonusValue}");

            Console.WriteLine($"Эльф полчуил бонус {nameof(Cherry)}: Здоровье эльфа: {elph.HP}");
        }
    }
}
