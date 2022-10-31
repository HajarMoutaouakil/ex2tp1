public class exercice2
{
    public static void Main()
    {
        int[] table = new int[100];
        int i, taille, a = 0; 
        int insert;
        Console.Write("Entrez la taille du tableau: ");
        taille = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entrer {0} elements Dans le Tableau:\n", taille);
        for (i = 0; i < taille; i++)
        {
            Console.Write("element ({0};{1}) : ", i, taille);
            table[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Entrez la valeur a etre inserer: ");
        insert = Convert.ToInt32(Console.ReadLine());
        Console.Write("Avant l'insertion:\n ");
        for (i = 0; i < taille; i++)
            Console.Write("{0} ", table[i]); 
        for (i = 0; i < taille; i++)
            if (insert < table[i])
            {
                a = i;
                break;
            }
        
        for (i = taille; i >= a; i--)
            table[i] = table[i - 1];
        
           table[a] = insert;

        Console.Write("\n\nApres l'insertion :\n ");
        for (i = 0; i <= taille; i++)
            Console.Write("{0} ", table[i]);
       Console.ReadLine();

            
    }
}
