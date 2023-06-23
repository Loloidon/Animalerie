using Crude;
using System.Text;

List<Dog> Dogs = new List<Dog>();
Dogs.Add(new Dog("Archie",10,DogRace.Dalmatien));
int input,age;
bool done = false;
string name;
string result = "";
do
{
    Console.WriteLine("Appuyer sur 0 pour sortir || 1 pour ajouter un chien || 2 pour afficher la liste || 3 pour enlever des éléments de la liste");
    input = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();

    switch (input)
    {

        case 0:done=true;
            Console.WriteLine("Aurevoir");
            
            break;

        case 1:
            Console.WriteLine("Entrez son nom,âge et race");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());





            foreach (DogRace p in Enum.GetValues<DogRace>())
            {
                sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

            }
            Console.WriteLine(sb);
            Console.WriteLine(result);


            string stringType = Console.ReadLine();

            int nbType = int.Parse(stringType);

            //PokemonType type = Enum.Parse<PokemonType>(stringType);
            DogRace race = (DogRace)nbType - 1;
            Dogs.Add(new Dog(name, age, race));


            break;
        case 2:
            foreach ( Dog dog in Dogs)
            {
                Console.WriteLine(dog);
            }

            break;
        case 3:
          

            break;
    } }while (!done);


