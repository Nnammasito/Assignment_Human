/*
Cree una clase Humana con cuatro campos públicos: Nombre (cadena), Fuerza (int), Inteligencia (int), Destreza (int)

Agregue un método constructor que tome una cadena para inicializar el Nombre, y que inicializará la Fuerza, la Inteligencia 
y la Destreza a un valor predeterminado de 3, y la salud al valor predeterminado de 100.

Creemos un constructor adicional que acepte 5 parámetros, para que podamos establecer valores personalizados para cada campo.

Ahora agregue un nuevo método llamado Ataque, que cuando se invoca, debería reducir la salud de un objeto Humano que se pasa como 
parámetro. El daño realizado debe ser 3 * fuerza (3 puntos de daño al atacado, por cada 1 punto de fuerza del atacante). 
Este método debería devolver el estado restante del objeto de destino.
*/

class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }

    //Constructor con un valor predeterminado
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    //Constructor con parametros personalizados
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = Intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    //Metodo para realizar un ataque.
    public int Attack(Human target)
    {
        int damage = 3 * Strength; //Calcula el daño
        target.Health -= damage; //Reduce la salud del objetivo
        return target.Health; //Devuelve la salud restante del objeto
    }
}

class Program
{
    static void Main()
    {
        Human player1 = new Human("Jugador 1");
        Human player2 = new Human("Jugador 2", 5, 4, 6, 120);

        Console.WriteLine($"{player1.Name}: Health = {player1.Health}");
        Console.WriteLine($"{player2.Name}: Health = {player2.Health}");

        // Realiza un ataque de player1 a player2
        player1.Attack(player2);

        Console.WriteLine($"{player1.Name} ataca a {player2.Name}");
        Console.WriteLine($"{player2.Name}: Health = {player2.Health}");

        player2.Attack(player1);
        Console.WriteLine($"{player2.Name} ataca a {player1.Name}");
        Console.WriteLine($"{player1.Name}: Health = {player1.Health}");
    }
}