
//Chriffrement 
void chiffrement(char cle, string phrase)//La clé doit être minuscule
{

    int n = phrase.Length;

    //Création du résultat : 
    char[] res = new char[n];
    int decalage = (int)cle - 97;
    //Parcours de la phrase
    for (int i = 0; i < n; i += 1)
    {
        char caractere = phrase[i];
        char nouveau = caractere;
        if ((int)caractere < 91 && (int)caractere > 64)//Le caractere est-il une majuscule 
        {
            if ((int)caractere + decalage >= 91)
                nouveau = (char)((int)caractere + decalage - 26);//Cas de dépassement de Z
            else
                nouveau = (char)((int)caractere + decalage);
        }
        else
            if ((int)caractere < 123 && (int)caractere > 96) //Le caractere est-il une minuscule ?
        {
            if ((int)caractere + decalage >= 123)
                nouveau = (char)((int)caractere + decalage - 26);//Cas de dépassement de Z
            else
                nouveau = (char)((int)caractere + decalage);
        }
        Console.Write(nouveau);


    }
}


chiffrement('b', "Bonjour Joanne Z");
