using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class Todo
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Todo(string description)
    {
        Description = description;
        IsCompleted = false; // Standardstatus: pågående
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{Description} ({(IsCompleted ? "Slutförd" : "Pågående")})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Todo> todoList = new List<Todo>();

        while (true)
        {
            // Huvudmeny
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till en ny ATT-GÖRA-uppgift");
            Console.WriteLine("2. Visa alla ATT-GÖRA-uppgifter");
            Console.WriteLine("3. Redigera en ATT-GÖRA-uppgift");
            Console.WriteLine("4. Avsluta");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Lägg till en ny uppgift
                    Console.Write("Ange beskrivning av uppgiften: ");
                    string description = Console.ReadLine();
                    Todo newTodo = new Todo(description);
                    todoList.Add(newTodo);
                    Console.WriteLine("Uppgift tillagd!");
                    break;

                case "2":
                    // Visa alla uppgifter
                    if (todoList.Count == 0)
                    {
                        Console.WriteLine("Ingen uppgift finns.");
                    }
                    else
                    {
                        Console.WriteLine("ATT-GÖRA-uppgifter:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                    }
                    break;

                case "3":
                    // Redigera en uppgift
                    if (todoList.Count == 0)
                    {
                        Console.WriteLine("Ingen uppgift finns att redigera.");
                    }
                    else
                    {
                        Console.WriteLine("Välj en uppgift att redigera:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }

                        // Läs in användarens val
                        Console.Write("Ange numret på uppgiften du vill redigera: ");
                        int taskNumber = int.Parse(Console.ReadLine()) - 1;

                        if (taskNumber >= 0 && taskNumber < todoList.Count)
                        {
                            // Fråga användaren efter ny beskrivning
                            Console.Write("Ange den nya beskrivningen för uppgiften: ");
                            string newDescription = Console.ReadLine();
                            todoList[taskNumber].Description = newDescription;
                            Console.WriteLine("Uppgiftens beskrivning har uppdaterats.");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt val.");
                        }
                    }
                    break;

                case "4":
                    // Avsluta programmet
                    Console.WriteLine("Programmet avslutas...");
                    return;

                default:
                    // Felaktigt val
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }

            Console.WriteLine(); // För att separera menyerna med en tom rad
        }
    }
}



/*
 
I denna uppgift ska du skapa en enkel ATT-GÖRA-app i C# och .NET. Appen låter användaren lägga till och visa ATT-GÖRA-uppgifter.

Exempel på hur det kan se ut:

Att göra:

- Handla mat (pågående)

- Tvätta bilen (slutförd)



Instruktioner


Mål: Skapa ett program som låter användaren skapa och visa en lista med ATT-GÖRA-uppgifter.


1. Skapa en Todo-klass

    Skapa en klass Todo med två egenskaper: Description (beskrivning av uppgiften) och IsCompleted (status på uppgiften, t.ex. om den är klar eller ej).


2. Skapa en lista för att lagra att göra-uppgifter

    I huvudprogrammet, skapa en List<Todo> för att lagra alla ATT-GÖRA-uppgifter som användaren skapar.


3. Bygg huvudmenyn

    Skapa en enkel meny som låter användaren välja mellan att:
    Lägg till en ny ATT-GÖRA-uppgift
    Visa alla ATT-GÖRA-uppgifter
    Avsluta programmet


4. Lägg till funktionalitet för att hantera uppgifter

    Om användaren väljer att lägga till en uppgift:
    Be dem skriva in uppgiften och lägg sedan till den i listan.
    Om användaren väljer att visa uppgifterna:
    Skriv ut alla uppgifter och deras status (klar eller ej).


5. Avsluta programmet

    Om användaren väljer att avsluta, avslutas programmet.
 
 */