// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/// <summary>
/// wyrazenie lambda
/// </summary>
var show = (string a) => { Console.WriteLine(a); }; // wyrazenie lambda funkcja anonimowa wypisujaca tekst
var iloczyn = (int x, int y) => { return x * y; };  // wyraenie lambda funkcja anoniowa iloczyn dwow liczb
show("jakis string");  // wywolanie funkcji anonimowej tekst, jako parametry staly tekst
show(iloczyn(2,3).ToString()); // wywolanie funkcji anonimowej teks, jako parametr funkcja anonimowa iloczyn
                                // wartosc zracana jest zamianiana na teks

