

//deklarujemy funkcję zwracającą stringa i przyjmującą stringa jako argument
string toAsciiCaesar(String clearText)
{
    //zamieniamy na wielkie litery
    clearText = clearText.ToUpper();
    //literuj przez cały tekst ltera po literze
    //deklarujemy string wynikowy
    string encryptedText = "";
    foreach (char c in clearText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej litery\
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartość klucza
            asciiCode += 3;
            //sprawdziamy czy nie przekroczyliśmy ostatniego znaku (z,90)
            if (asciiCode > 90)
                //jeśli przekroczyło to cofnij o długość alfabetu
                asciiCode -= 26;
            //zmieniamy kod z powrotem na znak
            char escryptedChar = (char)asciiCode;
            //dopisujemy do szyfu
            encryptedText += escryptedChar;
        }//zwroc zakodowany string
        
    }return encryptedText;
}
string fromAsciiCaesar(string encryptedText)
{
    string clearText = "";
    foreach (char c in encryptedText)
    {
        if (c >= 65 && c <= 90)
        {
            int asciiCode = (int)c;
            asciiCode -= 3;
            if (asciiCode > 90)
                asciiCode -= 26;
            char encryptedChar = (char)asciiCode;
            encryptedText += encryptedChar;
        }

        string uncryptedText = "";

    }
    return encryptedText;
}

//zdefiniuj string do zaszyfrowania
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia";


Console.WriteLine("Zaszyfrowany text: " + fromAsciiCaesar(clearText));