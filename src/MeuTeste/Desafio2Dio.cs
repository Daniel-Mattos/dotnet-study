using System;

class Desafio2Dio
{

  static void Main(string[] args)
  {

    double pi, raio, volume;
    pi = 3.14159;
    raio = double.Parse(Console.ReadLine());
    volume = pi * (4 / 3.0) * Math.Pow(raio, 3);

    Console.WriteLine($"VOLUME = {volume:F3}");
  }

}